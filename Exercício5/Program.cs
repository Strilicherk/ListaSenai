using System;

namespace Exercício5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 1; i <11; i++)
            {
                Console.WriteLine("---------------------------------------------");
                for (var a = 0; a <11; a++)
                {
                    Console.WriteLine($"{i} * {a} = {i * a}");
                }
            }
        }
    }
}
