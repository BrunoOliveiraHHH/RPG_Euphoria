using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Euphoria.Models
{
    public class Arma
    {
        private string Nome;
        private int Custo;
        private string Dano;
        private string TipoDeDano;
        private string Peso;
        private string Propriedades;
        private int Municao;
        private string Observacao;

        public Arma()
        {
        }

        public string nome { get; set; }
        public int custo { get; set; }
        public string dano { get; set; }

    }
}
