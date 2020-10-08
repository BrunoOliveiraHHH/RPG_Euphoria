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
            string user = txtUsuario.Text.Trim().ToString();
            string pass = txtSenha.Text.Trim().ToString();

            int flagPermitiUsuario = 0;

            if (!String.IsNullOrEmpty(user) && !String.IsNullOrEmpty(pass))
            {
                flagPermitiUsuario = _negocios.ValidaUsuarioLogado(user,pass);
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