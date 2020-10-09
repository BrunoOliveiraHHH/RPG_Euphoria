using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace RPG_Euphoria.Dados
{
    public class UsuariosDAO
    {
        private static string cs = ConfigurationManager.ConnectionStrings["SQLConnectString"].ConnectionString;
        private SqlConnection con = new SqlConnection(cs);
        private ParametroDAO parametro = new ParametroDAO();
        private SqlDataReader reader = null;

        public int ValidarUsuarioLogado(string username, string password)
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                string query = parametro.ConsultarParametro("procedureConsultarUsuario") + " @nome, @senha";
                SqlParameter nome = new SqlParameter();
                nome.ParameterName = "@nome";
                nome.Value = username;
                SqlParameter senha = new SqlParameter();
                senha.ParameterName = "@senha";
                senha.Value = password;
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(nome);
                cmd.Parameters.Add(senha);

                reader = cmd.ExecuteReader();
                dt.Load(reader);
                

                if (dt != null && dt.Rows.Count > 0)
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
    }
}
