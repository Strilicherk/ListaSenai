using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do produto");
            string nomeProduto = Console.ReadLine();
            Console.WriteLine("Insira a quatidade");
            int quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o preco");
            float preco = float.Parse(Console.ReadLine());

            TotalAPagar(nomeProduto,quantidade,preco);

            float TotalAPagar(string nome, int quantidade, float preco){
                float total = quantidade * preco;
                float desconto;
                if (quantidade<=5){
                    desconto = 0.02f;
                }else if(quantidade <=10){
                    desconto = 0.03f;
                }else{
                    desconto = 0.05f;
                }
                float valorDoDesconto = total * desconto;
                float totalComDesconto = total - valorDoDesconto;

                Console.WriteLine($"Sua Compra ficou em R${total}");
                Console.WriteLine($"Você ira receber R${valorDoDesconto} de desconto");
                Console.WriteLine($"Sua compra com desconto ficou em R${totalComDesconto}");

                return totalComDesconto;
            }
        }
    }
}
