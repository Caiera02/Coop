// See https://aka.ms/new-console-template for more information
using System.Runtime.Serialization;

namespace PrimeiroPrograma
{
    class Program
    {
        static void Main(string[] args) 
        {
            string nome;
            int idade;
            int number;
            int soma;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine( );

            Console.Write("Digite sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());
            
            soma = idade * 365;
            Console.WriteLine("Seu nome é: {0}",nome);
            Console.Write("Você já viveu: {0}",soma);

        }      
    }
    
}

