using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Euphoria.Models
{
    public class Armadura
    {
        #region Members
        private string Nome;
        private int Tipo;
        private int Custo;
        private string CA;
        private string Furtiv;
        private string Forca;
        private string Peso;
        private int Durablilidade;
        private string Observacao;
        #endregion

        #region Get's e Set's
        public string nome
        {
            get { return Nome; }
            set { Nome = value; }
        }
        public int tipo
        {
            get { return Tipo; }
            set { Tipo = value; }
        }
        public int custo
        {
            get { return Custo; }
            set { Custo = value; }
        }
        public string ca
        {
            get { return CA; }
            set { CA = value; }
        }
        public string furtv
        {
            get { return Furtiv; }
            set { Furtiv = value; }
        }
        public string forca
        {
            get { return Forca; }
            set { Forca = value; }
        }
        public string peso
        {
            get { return Peso; }
            set { Peso = value; }
        }
        public int durabilidade
        {
            get { return Durablilidade; }
            set { Durablilidade = value; }
        }
        public string observacao
        {
            get { return Observacao; }
            set { Observacao = value; }
        }
        #endregion

        #region Construtores
        public Armadura()
        {
        }
        public Armadura(string nome, int tipo, int custo, string ca, string furtv, string forca, string peso, int durabilidade, string observacao)
        {
            this.nome = nome;
            this.custo = custo;
            this.tipo = tipo;
            this.ca = ca;
            this.furtv = furtv;
            this.forca = forca;
            this.peso = peso;
            this.durabilidade = durabilidade;
            this.observacao = observacao;
        }
        public Armadura(string nome)
        {
            this.nome = nome;
        }
        #endregion
    }
}
