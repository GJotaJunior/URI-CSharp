using System;
using System.Globalization;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorA, valorB, valorC, valorD;

            string[] valores = Console.ReadLine().Split(' ');

            valorA = int.Parse(valores[0]);
            valorB = int.Parse(valores[1]);
            valorC = int.Parse(valores[2]);
            valorD = int.Parse(valores[3]);

            if (valorB > valorC && valorD > valorA && (valorC + valorD) > (valorA + valorB) && valorC >= 0 && valorD >= 0 && (valorA % 2) == 0)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
        }
    }
}