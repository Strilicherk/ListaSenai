using System;

namespace Exercício7
{
    class Program
    {
        static void Main(string[] args)
        {
             double[] numeros = new double[15];

            for (var i = 1; i <15; i++) {
                Console.WriteLine($"Digite o {i}° número: ");
                numeros[i] = double.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Sua lista com os números em ordem inversa é:");
            for (var i = 14; i >= 0; i--) {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine(numeros[i]);
            }
        }
    }
}