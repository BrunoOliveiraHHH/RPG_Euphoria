using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RPG_Euphoria.Negocios;

namespace RPG_Euphoria
{
    public partial class Protecao : System.Web.UI.Page
    {
        private Util util = new Util();
        private ArmadurasNegocio _negocios = new ArmadurasNegocio();

        protected void Page_Load(object sender, EventArgs e)
        {
            util.CarregaLinks(btnArmaMuni, btnArmadura, btnVeiculo, btnItem, btnMonstro);
            carregaDropDownDurabilidade();
            carregaDropDownTipoArmadura();
            carregaDropDownFurtiv();
        }

        private void carregaDropDownTipoArmadura()
        {
            _negocios.carregaDropDownTipoProtecao(cbxTipoProtecao);
        }

        private void carregaDropDownFurtiv()
        {
            _negocios.carregaComboBoxFurtiv(cbxFurtiv);
        }

        private void carregaDropDownDurabilidade()
        {
            _negocios.carregarComboBoxDurabilidade(cbxDurabilidade);
        }

        protected void btnAdiciona_Click(object sender, EventArgs e)
        {

        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        protected void btnPesquisar_Click(object sender, EventArgs e)
        {

        }
    }
}