using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RPG_Euphoria.Negocios;

namespace RPG_Euphoria
{
    public partial class ArmasMuni : System.Web.UI.Page
    {
        #region Members
        private Util util = new Util();
        private ArmasNegocio _negocios = new ArmasNegocio();
        #endregion

        #region Page_Load
        protected void Page_Load(object sender, EventArgs e)
        {
            util.CarregaLinks(btnArmaMuni, btnArmadura, btnVeiculo, btnItem, btnMonstro);
            carregaDropDownDurabilidade();
            carregaDropDownTipoArma();
            carregaDropDownCalibre();
            carregaGridViewArmaMuni();
        }

        private void carregaGridViewArmaMuni()
        {
            gridArmaMuni = _negocios.carregaGridView(gridArmaMuni);
        }

        private void carregaDropDownCalibre()
        {
            cbxCalibreMunicao = _negocios.carregaComboBoxCalibre(cbxCalibreMunicao);
        }      

        private void carregaDropDownDurabilidade()
        {            
            cbxDurabilidade = _negocios.carregarComboBoxDurabilidade(cbxDurabilidade);
        }

        private void carregaDropDownTipoArma()
        {
            cbxTipoArma = _negocios.carregaDropDownTipoArma(cbxTipoArma);
        }
        #endregion
    }
}