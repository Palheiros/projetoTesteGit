using System;

namespace projetoTeste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Olá, " + nome +"!");
            Console.Write("Quantos anos você tem? ");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int dias = idade * 365;
            Console.WriteLine(nome + ", você já viveu aproximadamente " + dias + " dias!");

        }
    }
}
