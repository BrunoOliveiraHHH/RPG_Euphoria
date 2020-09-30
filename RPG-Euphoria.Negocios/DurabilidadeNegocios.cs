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

        public void ListarDurabilidades(DropDownList comboBox)
        {
            _dao.ListarDurabilidades(comboBox);
        }

        public void GridDurabilidade(GridView dataGrid)
        {
            _dao.GridDurabilidade(dataGrid);
        }
    }
}
