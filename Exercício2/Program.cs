using System;

namespace Exercício2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o tipo do combustível (G - Gasolina ou A - Ácool): ");
            string tipo = Console.ReadLine();

            Console.WriteLine("Digite a quantidade em litros: ");
            float litros = float.Parse(Console.ReadLine());
            float precoAlcool = 4.9f;
            float precoGasolina = 5.3f;
            float resultadoDaFuncao;

            switch (tipo.ToLower())
            {
                case "a":
                        resultadoDaFuncao = ValorASerPago(litros,precoAlcool,0.03f,0.05f);
                        Console.WriteLine($"O valor a ser pago é de: {resultadoDaFuncao}");
                    break;
                case "g":
                        resultadoDaFuncao = ValorASerPago(litros,precoGasolina,0.04f,0.06f);
                default:
                    Console.WriteLine("Valor inválido");
                    break;
            }

            float ValorASerPago(float litros, float preco, float perc1, float perc2){
            float percetualDesconto;
                if (litros<=20){
                    percetualDesconto = perc1;
                } else {
                    percentualDesconto = perc2;       
                }
                float totalDoDesconto = (litros*preco) * percetualDesconto;
                float ValorBruto = (litros* preco);
                float ValorAPagar = ValorBruto - totalDoDesconto
                return ValorAPagar;
            }
            

            
            
        }
    }
}
