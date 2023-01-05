using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace PrimeiroOOP.Classe.Dados
{
    class Dados
    {
        //Treinamento, Programação Orientação ao Objeto
        //Inserindo dados, tipo string , int, double
        //Jonas Valereo - Técnico em Informática 

        //declarando os atributos, campos,variaveis da class dados

        private string _nome;
        private string _sobrenome;
        private int _idade;
        private double _peso;
        private string _cidade;
        private string _pais;

        //declarando o construtor da class dados

        public Dados(string nome, string sobrenome, int idade, double peso, string cidade, string pais)
        {
            _nome = nome;
            _sobrenome = sobrenome;
            _idade = idade;
            _peso = peso;
            _cidade = cidade;
            _pais = pais;
        }

        //declarando construtor padrão da class dados
        public Dados()
        {

        }

        //declarando propriedade nome, get e set da class dados
        public string Nome
        {
            get { return _nome; }
            set { _nome = value;  }
        }

        //declarando propriedade sobrenome, get e set da class dados
        public string Sobrenome
        {
            get { return _sobrenome; }
            set { _sobrenome = value; }
        }

        //declarando propriedade idade, get e set da class dados
        public int Idade
        {
            get { return _idade; }
            set { _idade = value; }
        }

        //declarando propriedade peso, get e set da class dados
        public double Peso
        {
            get { return _peso; }
            set { _peso = value; }
        }

        //declarando propriedade cidade, get e set da class dadoss
        public string Cidade
        {
            get { return _cidade;  }
            set { _cidade = value; }
        }

        //declarando propriedade pais, get e set da class dados
        public string Pais
        {
            get { return _pais; }
            set { _pais = value; }
        }

        //declarando método resultado da class dados

        public string Resultado()
        {
            return "Nome:" + Nome + " " + Sobrenome + " Idade:" + Idade + "anos "
               + " Peso:" + Peso.ToString("F2", CultureInfo.InvariantCulture)
                + " kg" + " Cidade:" + Cidade + " Pais:" + Pais;
        }

        //declarando modificador da class dados
        public override string ToString()
        {
            return Resultado().ToString();
        }

        //fim da class dados
    }
}
