using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using RPG_Euphoria.Dados;

namespace RPG_Euphoria.Negocios
{
    public class MunicaoNegocios
    {
        private MunicaoDAO _dao = new MunicaoDAO();

        public DropDownList carregaComboBoxCalibre(DropDownList dropDown)
        {
            return _dao.carregaComboBoxCalibre(dropDown);
        }
    }
}
