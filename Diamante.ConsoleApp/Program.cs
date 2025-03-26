using System;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;

namespace Diamante.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===========================================================================");
                Console.WriteLine("A pressão determina se um carvão se tornará diamente");
                Console.WriteLine("===========================================================================");
                bool success;
                int centerNumber;

                do
                {
                    Console.Write("Insira um número ÍMPAR de letras 'x' que irá compor o centro da jóia: ");
                    string entry = Console.ReadLine()!;
                    success = int.TryParse(entry, out centerNumber);

                    if (centerNumber == 1)
                    {
                        Console.WriteLine("-------------------------------------------------------------------");
                        Console.WriteLine("x");
                        Console.WriteLine("\nEssa jóia ficou muito pequena... tente um número maior!");
                        Console.WriteLine("-------------------------------------------------------------------");
                        continue;
                    }

                    if (!success || centerNumber % 2 == 0 || centerNumber <= 0)
                    {
                        Console.WriteLine("-------------------------------------------------------------------");
                        Console.Write("Erro! Digite um número ÍMPAR e INTEIRO.");
                        Console.WriteLine("\n-------------------------------------------------------------------");
                        continue;
                    }
                } while (!success || centerNumber % 2 == 0 || centerNumber <= 0 || centerNumber == 1);

                int[] MainArray = Enumerable.Range(1, centerNumber).Where(n => n % 2 != 0).ToArray();
                int[] SecundaryArray = MainArray.Reverse().Skip(1).ToArray();
                Console.WriteLine("\n");

                foreach (int num in MainArray)
                {
                    Console.WriteLine(new String(' ', (centerNumber - num) / 2) + new string('X', num));
                }

                foreach (int num in SecundaryArray)
                {
                    Console.WriteLine(new String(' ', (centerNumber - num) / 2) + new string('X', num));
                }
               
                Console.WriteLine("\n===========================================================================");
                Console.Write("Deseja criar um novo diamante? (S/N): ");
                Console.WriteLine("\n===========================================================================");
                string toContinue = Console.ReadLine()!.ToUpper();

                if (toContinue != "S")
                    break;
            }
        }
    }
}
