using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using RPG_Euphoria.Negocios;
using RPG_Euphoria.Models;

namespace RPG_Euphoria
{
    public partial class ArmasMuni : System.Web.UI.Page
    {
        #region Members
        private Util util = new Util();
        private ArmasNegocio _negocios = new ArmasNegocio();
        #endregion

        protected void btnAdiciona_Click(object sender, EventArgs e)
        {
            try
            {
                lblMensagem.Text = string.Empty;
                int custo = 0;
                string nome = txtBoxNome.Text.ToString();
                string dano = txtDadoDano.Text.ToString();
                string peso = txtPeso.Text.ToString();
                string tipoDano = txtTipoDano.Text.ToString();
                string propriedades = txtBoxPropriedade.Text.ToString();
                string observacao = cbxTipoArma.SelectedValue.ToString();
                if (!String.IsNullOrEmpty(txtCusto.Text.ToString()))
                {
                    custo = int.Parse(txtCusto.Text.ToString());
                }
                int municao = int.Parse(cbxCalibreMunicao.SelectedValue.ToString());
                int durabilidade = int.Parse(cbxDurabilidade.SelectedValue.ToString());

                Arma arma = new Arma(nome, custo, dano, tipoDano, peso, propriedades, municao, durabilidade, observacao);
                int retorno = _negocios.AdicionaArma(arma);

                if (retorno > 0)
                {
                    lblMensagem.Text = "Arma adicionada com sucesso";
                    CarregaEstiloLblMensagem(lblMensagem);
                    Page.Response.Redirect(Page.Request.Url.ToString(), false);
                    Context.ApplicationInstance.CompleteRequest();
                }
            }
            catch (Exception ex)
            {
                lblMensagem.Text = "Erro ao adicionar a arma. Error: " + ex.Message.ToString();
                CarregaEstiloLblMensagem(lblMensagem);
            }

        }

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
             _negocios.carregaGridView(gridArmaMuni);
        }

        private void carregaDropDownCalibre()
        {
            if (cbxCalibreMunicao.Items.Count <= 0)
            {
                _negocios.carregaComboBoxCalibre(cbxCalibreMunicao);
            }
        }

        private void carregaDropDownDurabilidade()
        {
            if (cbxDurabilidade.Items.Count <= 0)
            {
                _negocios.carregarComboBoxDurabilidade(cbxDurabilidade);
            }
        }

        private void carregaDropDownTipoArma()
        {
             _negocios.carregaDropDownTipoArma(cbxTipoArma);
        }
        #endregion

        

        private void CarregaEstiloLblMensagem(Label lblMensagem)
        {
            lblMensagem.BackColor = Color.White;
            lblMensagem.BorderColor = Color.Black;
            lblMensagem.BorderStyle = BorderStyle.Solid;
            lblMensagem.BorderWidth = Unit.Pixel(1);
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        protected void btnPesquisar_Click(object sender, EventArgs e)
        {

        }
    }
}