using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using PrimeiroOOP.Classe.Dados;

namespace PrimeiroOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Treinamento, Programação Orientação ao Objeto
            //Inserindo dados, tipo string , int, double
            //Jonas Valereo - Técnico em Informática 

            //declarando o objeto resul da class program
            Dados resul = new Dados();

            //Declarando o codigo entrada de dado no console, método ReadLine
            Console.WriteLine("Digite seus dados pessoais: ");
            Console.WriteLine();
            Console.Write("Nome: ");
            resul.Nome = Console.ReadLine();
            Console.Write("Sobrenome: ");
            resul.Sobrenome = Console.ReadLine();
            Console.Write("Idade: ");
            resul.Idade = int.Parse(Console.ReadLine());
            Console.Write("Peso: ");
            resul.Peso = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Cidade: ");
            resul.Cidade = Console.ReadLine();
            Console.Write("Pais: ");
            resul.Pais = Console.ReadLine();

            //imprimir saida de dados no console, método WhriteLine
            Console.WriteLine();
            Console.WriteLine(resul.ToString());
            
            //saida do aplicativo console, método Readkey, Retorna o valor da tecla pressionada
            Console.ReadKey();
        }

        //fim do programa 
    }
}
