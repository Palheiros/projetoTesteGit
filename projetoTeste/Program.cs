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
            Console.ReadLine();
        }
    }
}
