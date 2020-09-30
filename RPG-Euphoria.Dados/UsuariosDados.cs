using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace RPG_Euphoria.Dados
{
    public class UsuariosDados
    {
        private static string cs = ConfigurationManager.ConnectionStrings["SQLConnectString"].ConnectionString;
        private SqlConnection con = new SqlConnection(cs);
        private ParametroDAO parametro = new ParametroDAO();

        public int ValidarUsuarioLogado(string username, string password)
        {
            return 1;
        }
    }
}
