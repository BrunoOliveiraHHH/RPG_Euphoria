using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using RPG_Euphoria;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Data;

namespace RPG_Euphoria.Dados
{
    public class MunicaoDAO
    {
        #region Members
        private static string cs = ConfigurationManager.ConnectionStrings["SQLConnectString"].ConnectionString;
        private SqlConnection con = new SqlConnection(cs);
        private SqlDataReader reader = null;
        private ParametroDAO parametro = new ParametroDAO();
        #endregion

        #region carregaComboBoxCalibre
        public void carregaComboBoxCalibre(DropDownList dropDown)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();

                String query = parametro.ConsultarParametro("procedureListaMuniIdNome");
                SqlCommand cmd = new SqlCommand(query, con);
                reader = cmd.ExecuteReader();
                dt.Load(reader);

                if (dt != null && dt.Rows.Count > 0)
                {
                    dropDown.DataTextField = "nome";
                    dropDown.DataValueField = "id_municao";
                    dropDown.DataSource = dt;
                    dropDown.DataBind();
                }
                dropDown.Items.Insert(0,new ListItem("Selecione", "0"));

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
