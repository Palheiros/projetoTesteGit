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

            Console.WriteLine($"Olá, {nome}!");
            
            Console.Write("Quantos anos você tem? ");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine();
            
            int dias = idade * 365;
            Console.WriteLine($"{nome}, você já viveu aproximadamente {dias} dias!");
            Console.WriteLine();

            if (idade < 18)
            {
                Console.WriteLine("Usuário menor de idade. Acesso não autorizado!");
            } else
            {
                Console.WriteLine("Maior de idade. Pode prosseguir com o login.");
            }

            DateTime tempo = DateTime.Now;

            if (tempo.Hour > 6 && tempo.Hour < 12)
                Console.WriteLine($"Bom dia, {nome}!");
            else if (tempo.Hour >= 12 && tempo.Hour < 18)
                Console.WriteLine($"Boa tarde, {nome}!");
            else
                Console.WriteLine($"Boa noite, {nome}!");

        }
    }
}
