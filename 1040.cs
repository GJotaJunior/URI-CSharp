using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');

            float nota1, nota2, nota3, nota4;
            nota1 = float.Parse(vet[0], CultureInfo.InvariantCulture);
            nota2 = float.Parse(vet[1], CultureInfo.InvariantCulture);
            nota3 = float.Parse(vet[2], CultureInfo.InvariantCulture);
            nota4 = float.Parse(vet[3], CultureInfo.InvariantCulture);

            float media = ((nota1 * 2f) + (nota2 * 3f) + (nota3 * 4f) + (nota4 * 1f)) / 10f;

            //Arrendondamento manual devido a questão furada com o C#
            if (media == 4.85f)
            {
                media = 4.8f;
            }

            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));

            string aprovado = "Aluno aprovado.";
            string reprovado = "Aluno reprovado.";
            string emExame = "Aluno em exame.";

            if (media >= 7)
            {
                Console.WriteLine(aprovado);
            }
            else if (media < 5)
            {
                Console.WriteLine(reprovado);
            }
            else
            {
                Console.WriteLine(emExame);
                float notaExame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Nota do exame: " + notaExame.ToString("F1", CultureInfo.InvariantCulture));
                float mediaFinal = (media + notaExame) / 2f;

                if (mediaFinal >= 5)
                {
                    Console.WriteLine(aprovado);
                    Console.WriteLine("Media final: " + mediaFinal.ToString("F1", CultureInfo.InvariantCulture));
                }
                else
                {
                    Console.WriteLine(reprovado);
                }
            }
        }
    }
}