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
        protected void Page_Load(object sender, EventArgs e)
        {
            CarregaLinks();
        }
        private void CarregaLinks()
        {
            ParametroNegocios _negocios = new ParametroNegocios();
            string nomParametro = "ListaBtnMenu";
            List<string> stringList = _negocios.ConsultarListaParametros(nomParametro);

            foreach (string link in stringList.AsEnumerable())
            {
                if (!String.IsNullOrEmpty(link))
                {
                    switch (link)
                    {
                        case "ArmaMuniOFF":
                            btnArmaMuni.Visible = true;
                            break;
                        case "ArmaduraOFF":
                            btnArmadura.Visible = true;
                            break;
                        case "VeiculoOFF":
                            btnVeiculo.Visible = true;
                            break;
                        case "ItemOFF":
                            btnItem.Visible = true;
                            break;
                        case "MonstroOFF":
                            btnMonstro.Visible = true;
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}