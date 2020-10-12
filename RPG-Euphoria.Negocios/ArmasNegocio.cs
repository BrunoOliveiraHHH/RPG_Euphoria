using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using RPG_Euphoria.Dados;
using RPG_Euphoria.Models;

namespace RPG_Euphoria.Negocios
{
    public class ArmasNegocio
    {
        DurabilidadeNegocios _negociosDurabilidade = new DurabilidadeNegocios();
        MunicaoNegocios _negociosMunicao = new MunicaoNegocios();
        ArmaDAO _dao = new ArmaDAO();

        #region Métodos que carregam os DropDowns e Grid da Pagina "Armas e Munição"
        public void carregarComboBoxDurabilidade(DropDownList dropDown)
        {
            _negociosDurabilidade.ListarDurabilidades(dropDown);
        }

        public void carregaComboBoxCalibre(DropDownList dropDown)
        {
            _negociosMunicao.carregaComboBoxCalibre(dropDown);
        }
        public void carregaDropDownTipoArma(DropDownList dropDown)
        {
            dropDown.Items.Insert(0, new ListItem("Selecione", "Vazio"));
            dropDown.Items.Insert(1, new ListItem("Arma Branca", "Arma Branca"));
            dropDown.Items.Insert(2, new ListItem("Arma de Fogo Pequena", "Arma Pequena"));
            dropDown.Items.Insert(3, new ListItem("Arma de Fogo Grande", "Arma Grande"));
            dropDown.Items.Insert(4, new ListItem("Explosivos", "Explosivos"));
        }

        public void carregaGridView(GridView dataGrid)
        {
             _dao.carregaGridArmaMuni(dataGrid);
        }
        #endregion

        public int AdicionaArma(Arma arma)
        {
                string retornoValidacao = ValidaCampoArma(arma);

                if (retornoValidacao.Length <= 0)
                {
                    return _dao.AdicionaArma(arma);
                }
                else
                {
                    return 0;
                }
            
        }

        private string ValidaCampoArma(Arma arma)
        {
            string messagem = "";
            if (String.IsNullOrEmpty(arma.nome))
            {
                messagem = "Campo 'Nome' não informado, favor preencher";
            }
            else if (String.IsNullOrEmpty(arma.dano))
            {
                messagem += " Campo 'Dano' não informado, favor preencher";
            }
            else if (String.IsNullOrEmpty(arma.tipoDeDano))
            {
                messagem +=" Campo 'Tipo de Dano' não informado, favor preencher";
            }
            else if (String.IsNullOrEmpty(arma.propriedades))
            {
                messagem += " Campo 'Propriedades' não informado, favor preencher";
            }
            else if (String.IsNullOrEmpty(arma.peso))
            {
                messagem += " Campo 'Peso' não informado, favor preencher";
            }
            else if (arma.municao == 0)
            {
                messagem += " Campo 'Calibre' não informado, favor preencher";
            }
            else if (arma.durabilidade == 0)
            {
                messagem += " Campo 'Durabilidade' não informado, favor preencher";
            }
            else if (String.IsNullOrEmpty(arma.observacao) || arma.observacao == "Vazio")
            {
                messagem += " Campo 'Tipo de Arma' não informado, favor preencher";
            }

            return messagem;
        }

    }
}
