using System;

namespace Exercício6
{
    class Program
    {
        static void Main(string[] args)
        {   
            string[] nomes = new string[4];
            string nomepesquisa;
            Console.WriteLine("Este algoritmo permite que você digite 10 nomes e depois você pode pesquisar por um nome para \nverificar se o mesmo consta na lista ");
            System.Threading.Thread.Sleep(1000);

            for (var i = 1; i < nomes.Length; i++)
            {
                Console.WriteLine($"Digite o {i}º nome");
                nomes[i] = Console.ReadLine().ToLower();
            }
            foreach (string nome in nomes)
            {
            Console.WriteLine("Digite o nome que deseja pesquisar");
            nomepesquisa = Console.ReadLine().ToLower();
            
                if (nomepesquisa == nome)
                {
                    Console.WriteLine($"Nome {nome} encontrado");
                    break;
                } else
                {
                    Console.WriteLine("Nome não encontrado");
                    break;
                }
            }
        }
    }
}
