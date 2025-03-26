using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamante.ConsoleApp
{
    class DiamondGenerators
    {
        public static int[] mainArray, secundaryArray;
        
        public static void ArraysGenerator()
        {
            mainArray = Enumerable.Range(1, Validação.centerNumber).Where(n => n % 2 != 0).ToArray();
            secundaryArray = mainArray.Reverse().Skip(1).ToArray();
            Console.WriteLine("\n");
        }

        public static void DiamondCreator()
        {
            foreach (int num in mainArray)
            {
                Console.WriteLine(new String(' ', (Validação.centerNumber - num) / 2) + new string('X', num));
            }

            foreach (int num in secundaryArray)
            {
                Console.WriteLine(new String(' ', (Validação.centerNumber - num) / 2) + new string('X', num));
            }
        }
    }
}
