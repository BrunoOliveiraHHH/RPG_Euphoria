using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Data;
using RPG_Euphoria.Models;

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

        #region Carrega Grid
        public void carregaGridArmaMuni(GridView dataGrid)
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
            dt.Columns["durabiliade_arma"].ColumnName = "Estado de Durabilidade da Arma";

        }
        #endregion

        #region AdicionaArma
        public int AdicionaArma(Arma arma)
        {
            DataTable dt = new DataTable();

            try
            {
                con.Open();

                #region Monta a query
                String query = "EXECUTE [dbo].[adiciona_arma] @nome, @custo, @dano, @tipo_de_dano, @peso, @propriedade, @municao, @durabilidade, @observacao";
                SqlCommand cmd = new SqlCommand(query, con);

                #region Parametro nome
                SqlParameter nome = new SqlParameter();
                nome.ParameterName = "nome";
                nome.Value = arma.nome;
                #endregion

                #region Parametro custo
                SqlParameter custo = new SqlParameter();
                custo.ParameterName = "custo";
                custo.Value = arma.custo;
                custo.SqlDbType = SqlDbType.Int;
                #endregion

                #region Parametro dano
                SqlParameter dano = new SqlParameter();
                dano.ParameterName = "dano";
                dano.Value = arma.dano;
                #endregion

                #region Parametro tipo_de_dano
                SqlParameter tipoDano = new SqlParameter();
                tipoDano.ParameterName = "tipo_de_dano";
                tipoDano.Value = arma.tipoDeDano;
                #endregion

                #region Parametro peso
                SqlParameter peso = new SqlParameter();
                peso.ParameterName = "peso";
                peso.Value = arma.peso;
                #endregion

                #region Parametro propriedade
                SqlParameter propriedade = new SqlParameter();
                propriedade.ParameterName = "propriedade";
                propriedade.Value = arma.propriedades;
                #endregion

                #region Parametro municao
                SqlParameter municao = new SqlParameter();
                municao.ParameterName = "municao";
                municao.Value = arma.municao;
                municao.SqlDbType = SqlDbType.Int;
                #endregion

                #region Parametro durabilidade
                SqlParameter durabilidade = new SqlParameter();
                durabilidade.ParameterName = "durabilidade";
                durabilidade.Value = arma.durabilidade;
                durabilidade.SqlDbType = SqlDbType.Int;
                #endregion

                #region Parametro observacao
                SqlParameter observacao = new SqlParameter();
                observacao.ParameterName = "observacao";
                observacao.Value = arma.observacao;
                #endregion

                cmd.Parameters.Add(nome);
                cmd.Parameters.Add(custo);
                cmd.Parameters.Add(dano);
                cmd.Parameters.Add(tipoDano);
                cmd.Parameters.Add(peso);
                cmd.Parameters.Add(propriedade);
                cmd.Parameters.Add(municao);
                cmd.Parameters.Add(durabilidade);
                cmd.Parameters.Add(observacao);
 
                #endregion

                
                reader = cmd.ExecuteReader();
                dt.Load(reader);

                //Validação para retorno de mensagem em tela
                if (dt != null)
                {
                    return 1;
                }
                else
                {
                    return 0;
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

        }
        #endregion
    }
}
