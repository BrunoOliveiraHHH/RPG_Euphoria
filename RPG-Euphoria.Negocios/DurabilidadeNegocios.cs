using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RPG_Euphoria.Dados;

namespace RPG_Euphoria.Negocios
{
    public class DurabilidadeNegocios
    {
        private DurabilidadeDAO _dao = new DurabilidadeDAO();

        public void ListarDurabilidades(DropDownList comboBox)
        {
           _dao.ListarDurabilidades(comboBox);
        }

        public GridView GridDurabilidade(GridView dataGrid)
        {
           return _dao.GridDurabilidade(dataGrid);
        }
    }
}
