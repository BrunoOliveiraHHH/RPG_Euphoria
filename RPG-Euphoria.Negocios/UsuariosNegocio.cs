using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPG_Euphoria.Dados;

namespace RPG_Euphoria.Negocios
{
    public class UsuariosNegocio
    {
        private UsuariosDAO _dao = new UsuariosDAO();
        public int ValidaUsuarioLogado(string username, string password)
        {
            return _dao.ValidarUsuarioLogado(username, password);
        }

    }
}
