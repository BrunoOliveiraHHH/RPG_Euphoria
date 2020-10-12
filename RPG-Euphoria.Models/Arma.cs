using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Euphoria.Models
{
    public class Arma
    {
        #region Members
        private string Nome;
        private int Custo;
        private string Dano;
        private string TipoDeDano;
        private string Peso;
        private string Propriedades;
        private int Municao;
        private int Durabilidade;
        private string Observacao;
        #endregion

        #region Get's e Set's
        public string nome
        {
            get { return Nome; }
            set { Nome = value; }
        }
        public int custo
        {
            get { return Custo; }
            set { Custo = value; }
        }
        public string dano
        {
            get { return Dano; }
            set { Dano = value; }
        }
        public string tipoDeDano
        {
            get { return TipoDeDano; }
            set { TipoDeDano = value; }
        }
        public string peso
        {
            get { return Peso; }
            set { Peso = value; }
        }
        public string propriedades
        {
            get { return Propriedades; }
            set { Propriedades = value; }
        }
        public int municao
        {
            get { return Municao; }
            set { Municao = value; }
        }
        public int durabilidade
        {
            get { return Durabilidade; }
            set { Durabilidade = value; }
        }
        public string observacao
        {
            get { return Observacao; }
            set { Observacao = value; }
        }
        #endregion

        #region Construtores
        public Arma()
        {
        }
        public Arma(string nome, int custo, string dano, string tipoDano, string peso, string propriedades, int municao, int durabilidade, string observacao)
        {
            this.nome = nome;
            this.custo = custo;
            this.dano = dano;
            this.tipoDeDano = tipoDano;
            this.peso = peso;
            this.propriedades = propriedades;
            this.municao = municao;
            this.durabilidade = durabilidade;
            this.observacao = observacao;
        }
        public Arma(string nome)
        {
            this.nome = nome;
        }
        #endregion

    }
}
