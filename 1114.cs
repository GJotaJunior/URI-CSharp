using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha = int.Parse(Console.ReadLine());

            string permitido = "Acesso Permitido", negado = "Senha Invalida";

            while (senha != 2002)
            {
                Console.WriteLine(negado);

                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(permitido);
        }
    }
}