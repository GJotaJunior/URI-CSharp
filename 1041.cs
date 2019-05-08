using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');

            double pontoX = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double pontoY = double.Parse(vet[1], CultureInfo.InvariantCulture);

            if (pontoX == 0 && pontoY == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (pontoX == 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (pontoY == 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (pontoX > 0 && pontoY > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (pontoX < 0 && pontoY > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (pontoX < 0 && pontoY < 0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }
        }
    }
}