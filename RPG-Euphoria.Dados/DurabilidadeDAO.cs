using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Configuration;
using RPG_Euphoria;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace RPG_Euphoria.Dados
{
    public class DurabilidadeDAO
    {
        private static string cs = ConfigurationManager.ConnectionStrings["SQLConnectString"].ConnectionString;
        private SqlConnection con = new SqlConnection(cs);
        private ParametroDAO parametro = new ParametroDAO();
        private SqlDataReader reader = null;

        public void ListarDurabilidades(DropDownList comboBox)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();

                String query = parametro.ConsultarParametro("procedureListarDurabilidade");
                SqlCommand cmd = new SqlCommand(query, con);
                reader = cmd.ExecuteReader();
                dt.Load(reader);

                if (dt != null && dt.Rows.Count > 0)
                {
                    comboBox.DataTextField = "descricao";
                    comboBox.DataValueField = "id_durabilidade";
                    comboBox.DataSource = dt;
                    comboBox.DataBind();
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

        public GridView GridDurabilidade(GridView dataGrid) 
        {
            DataTable dt = new DataTable();

            try
            {
                con.Open();
                String query = parametro.ConsultarParametro("procedureListarDurabilidade");
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter();
                reader = cmd.ExecuteReader();
                dt.Load(reader);

                if (dt != null && dt.Rows.Count > 0)
                {
                    dt.Columns["id_durabilidade"].ColumnName = "ID";
                    dt.Columns["descricao"].ColumnName = "Descrição";
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
    }
}
