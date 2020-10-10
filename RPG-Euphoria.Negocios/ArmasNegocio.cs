using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using RPG_Euphoria.Dados;

namespace RPG_Euphoria.Negocios
{
    public class ArmasNegocio
    {
        DurabilidadeNegocios _negociosDurabilidade= new DurabilidadeNegocios();
        MunicaoNegocios _negociosMunicao = new MunicaoNegocios();
        ArmaDAO _dao = new ArmaDAO();

        #region Métodos que carregam os DropDowns da Pagina "Armas e Munição"
        public DropDownList carregarComboBoxDurabilidade(DropDownList dropDown)
        {
            return _negociosDurabilidade.ListarDurabilidades(dropDown);
        }

        public DropDownList carregaComboBoxCalibre(DropDownList dropDown)
        {
            return _negociosMunicao.carregaComboBoxCalibre(dropDown);
        }
        public DropDownList carregaDropDownTipoArma(DropDownList dropDown)
        {
            dropDown.Items.Insert(0, new ListItem("Selecione", "Vazio"));
            dropDown.Items.Insert(1, new ListItem("Arma Branca", "Arma Branca"));
            dropDown.Items.Insert(2, new ListItem("Arma de Fogo Pequena", "Arma Pequena"));
            dropDown.Items.Insert(3, new ListItem("Arma de Fogo Grande", "Arma Grande"));
            dropDown.Items.Insert(4, new ListItem("Explosivos", "Explosivos"));

            return dropDown;
        }

        public GridView carregaGridView(GridView dataGrid)
        {
            return _dao.carregaGridArmaMuni(dataGrid);
        }
        #endregion
    }
}
