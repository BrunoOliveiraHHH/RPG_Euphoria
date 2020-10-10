using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RPG_Euphoria.Negocios;

namespace RPG_Euphoria
{
    public class Util
    {
        public void CarregaLinks(HyperLink btnArmaMuni, HyperLink btnArmadura, HyperLink btnVeiculo, HyperLink btnItem, HyperLink btnMonstro)
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
                        case "ArmaMuniON":
                            btnArmaMuni.Visible = true;
                            break;
                        case "ArmaduraON":
                            btnArmadura.Visible = true;
                            break;
                        case "VeiculoON":
                            btnVeiculo.Visible = true;
                            break;
                        case "ItemON":
                            btnItem.Visible = true;
                            break;
                        case "MonstroON":
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