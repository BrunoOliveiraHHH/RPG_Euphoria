using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RPG_Euphoria.Negocios
{
    public class DurabilidadeNegocios
    {
        private Dados.DurabilidadeDAO _dao = new Dados.DurabilidadeDAO();

        public DropDownList ListarDurabilidades(DropDownList comboBox)
        {
           return _dao.ListarDurabilidades(comboBox);
        }

        public GridView GridDurabilidade(GridView dataGrid)
        {
           return _dao.GridDurabilidade(dataGrid);
        }
    }
}
