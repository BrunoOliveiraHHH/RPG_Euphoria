using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RPG_Euphoria.Negocios;

namespace RPG_Euphoria.Usuarios
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            UsuariosNegocio _negocios = new UsuariosNegocio();

            int flagPermitiUsuario = 0;

            if (!String.IsNullOrEmpty(txtUsuario.Text.Trim().ToString()) && !String.IsNullOrEmpty(txtSenha.Text.Trim().ToString()))
            {
                flagPermitiUsuario = _negocios.ValidaUsuarioLogado(txtUsuario.Text.Trim().ToString(), txtSenha.Text.Trim().ToString());
            }
            else
            {
                lblMensagemErro.Text = "Preencha os dois campos corretamente";
            }

            if (flagPermitiUsuario > 0)
            {
                Response.Redirect("../Menu.aspx");
            }
            else
            {
                lblMensagemErro.Text = "Usuário não permitido";
            }

        }
    }
}