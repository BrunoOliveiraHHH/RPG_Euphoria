using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using RPG_Euphoria.Dados;

namespace RPG_Euphoria.Negocios
{
    public class ArmadurasNegocio
    {
        DurabilidadeNegocios _negociosDurabilidade = new DurabilidadeNegocios();
        ArmadurasDAO _dao = new ArmadurasDAO();

        public void carregarComboBoxDurabilidade(DropDownList dropDown)
        {
            _negociosDurabilidade.ListarDurabilidades(dropDown);
        }
        public void carregaComboBoxFurtiv(DropDownList dropDown)
        {
            dropDown.Items.Insert(0, new ListItem("Selecione", "Vazio"));
            dropDown.Items.Insert(1, new ListItem("Desvantagem", "Desvantagem"));
            dropDown.Items.Insert(2, new ListItem("Não-Desvantagem", "Não-Desvantagem"));
            dropDown.Items.Insert(3, new ListItem("Não Aplica Desvantagem", "-"));
        }
        public void carregaDropDownTipoProtecao(DropDownList dropDown)
        {
            dropDown.Items.Insert(0, new ListItem("Selecione", "Vazio"));
            dropDown.Items.Insert(1, new ListItem("Leve", "Leve"));
            dropDown.Items.Insert(2, new ListItem("Média", "Média"));
            dropDown.Items.Insert(3, new ListItem("Pesada", "Pesada"));
        }

        public void carregaGridView(GridView dataGrid)
        {
            _dao.carregaGridProtecao(dataGrid);
        }
    }
}
