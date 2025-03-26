using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamante.ConsoleApp
{
    public class Começo_e_Fim
    {
        public static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("===========================================================================");
            Console.WriteLine("A pressão determina se um carvão se tornará diamente");
            Console.WriteLine("===========================================================================");
        }
        public static bool Restart()
        {
            while (true)
            {
                Console.WriteLine("\n===========================================================================");
                Console.Write("Deseja criar um novo diamante? (S/N): ");
                Console.WriteLine("\n===========================================================================");
                string toContinue = Console.ReadLine()!.ToUpper();

                if (toContinue == "S")
                {
                    return true;
                }
                else if (toContinue == "N")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("-------------------------------------------------------------------");
                    Console.WriteLine("Erro! Por favor, digite 'S' para Sim ou 'N' para Não.");
                    Console.WriteLine("-------------------------------------------------------------------");
                }
            }
        }

    }
}
