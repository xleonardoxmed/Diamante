using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Diamante.ConsoleApp
{

    public class Validação
    {
        public static int centerNumber;
        public static bool success;
        public static int EntryValidation()
        {
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
            return centerNumber;
        }


    }
}
