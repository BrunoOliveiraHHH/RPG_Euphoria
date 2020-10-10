using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Data;

namespace RPG_Euphoria.Dados
{
    public class ArmaDAO
    {
        #region Members
        private static string cs = ConfigurationManager.ConnectionStrings["SQLConnectString"].ConnectionString;
        private SqlConnection con = new SqlConnection(cs);
        private SqlDataReader reader = null;
        private ParametroDAO parametro = new ParametroDAO();
        #endregion

        public GridView carregaGridArmaMuni(GridView dataGrid)
        {
            DataTable dt = new DataTable();

            try
            {
                con.Open();
                String query = parametro.ConsultarParametro("procedureConsultaArmaMunicao");
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter();
                reader = cmd.ExecuteReader();
                dt.Load(reader);

                if (dt != null && dt.Rows.Count > 0)
                {
                    renomaValoresDataTable(dt);
                    renomeaColunasDataTable(dt);                    
                    dataGrid.DataSource = dt;
                    dataGrid.ShowHeader = true;
                    dataGrid.DataBind();
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
                if (reader != null)
                {
                    reader.Close();
                }
            }

            return dataGrid;

        }

        private void renomaValoresDataTable(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                string value = row["observacao_arma"].ToString();

                if (value == "Armas Pequenas")
                {
                    value = "Arma de Fogo Pequena";
                    row["observacao_arma"] = value;
                }
                else if (value == "Armas Grandes")
                {
                    value = "Arma de Fogo Grande";
                    row["observacao_arma"] = value;
                }
            }
        }

        private void renomeaColunasDataTable(DataTable dt)
        {
            dt.Columns["ID"].ColumnName = "ID";
            dt.Columns["nome_arma"].ColumnName = "Nome da Arma";
            dt.Columns["custo_arma"].ColumnName = "Preço";
            dt.Columns["dano_arma"].ColumnName = "Dado de Dano";
            dt.Columns["tipo_de_dano_arma"].ColumnName = "Tipo de Dano";
            dt.Columns["peso_arma"].ColumnName = "Peso";
            dt.Columns["propriedade_arma"].ColumnName = "Propriedades";
            dt.Columns["nome_municao"].ColumnName = "Nome Completo Municão";
            dt.Columns["custo_municao"].ColumnName = "Preço da Munição";
            dt.Columns["calibre_municao"].ColumnName = "Calibre";
            dt.Columns["quantidade_municao"].ColumnName = "Quantidade por Caixa";
            dt.Columns["observacao_municao"].ColumnName = "Informações Adicionais";
            dt.Columns["observacao_arma"].ColumnName = "Tipo da Arma";

        }
    }
}
