using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RPG_Euphoria.Negocios;

namespace RPG_Euphoria
{
    public partial class Menu : System.Web.UI.Page
    {
        private Util util = new Util();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            util.CarregaLinks(btnArmaMuni, btnArmadura, btnVeiculo, btnItem, btnMonstro);
        }

        
    }
}