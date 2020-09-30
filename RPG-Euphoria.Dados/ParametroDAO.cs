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
    public class ParametroDAO
    {
        private static string cs = ConfigurationManager.ConnectionStrings["SQLConnectString"].ConnectionString;
        private SqlConnection con = new SqlConnection(cs);
        private SqlDataReader reader = null;

        public string ConsultarParametro(string nom_parametro)
        {
            string parametro = "";
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                String query = "EXECUTE [dbo].[consultar_parametro] @nom_parametro";
                SqlParameter parametros = new SqlParameter();
                parametros.ParameterName = "@nom_parametro";
                parametros.Value = nom_parametro;
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(parametros);

                reader = cmd.ExecuteReader();

                dt.Load(reader);

                if (dt != null && dt.Rows.Count > 0)
                {
                    parametro = dt.Rows[0]["des_parametro"].ToString();
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
                if( reader != null)
                {
                    reader.Close();
                }
            }

            return parametro;
        }
    }
}
