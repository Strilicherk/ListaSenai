using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int nascimento;
            int atual;
            int idade;
            Console.Write("Digite o ano em que você nasceu: ");
            nascimento = int.Parse(Console.ReadLine());
            Console.Write("Digite o ano atual: ");
            atual = int.Parse(Console.ReadLine());

            idade=atual-nascimento;
            if (idade>=16)
            {
                Console.WriteLine("Você está apto a votar");
            } else
            {
              Console.WriteLine("Você ainda não possui idade suficiente para votar");
            }
        }
    }
}

