using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPG_Euphoria.Dados;
using System.Web.UI.WebControls;

namespace RPG_Euphoria.Negocios
{
    public class ParametroNegocios
    {
        private ParametroDAO _dao = new ParametroDAO();

        public string ConsultarParametro(string nomParametro)
        {
            return _dao.ConsultarParametro(nomParametro);
        }

        public List<string> ConsultarListaParametros(string nomParametro)
        {
            return _dao.ConsultarListaParametros(nomParametro);
        }
    }
}
