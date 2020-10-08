using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RPG_Euphoria
{
    public partial class ArmasMuni : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            carregaLinks();
        }

        private void carregaLinks()
        {
            btnArmadura.Visible = true;
            btnArmaMuni.Visible = true;
            btnHomePage.Visible = true;
            btnItem.Visible = true;
            btnMonstro.Visible = true;
            btnVeiculo.Visible = true;
        }
    }
    }
}