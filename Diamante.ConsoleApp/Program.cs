namespace Diamante.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("==========================================================");
                Console.WriteLine("A pressão determina se um carvão se tornará diamente");
                Console.WriteLine("==========================================================");
                bool success;
                int centerNumber = 0;

                do
                {
                    Console.WriteLine("Insira o número ÍMPAR de letras 'x' que irá compor o centro da jóia: ");
                    string entry = Console.ReadLine()!;
                    success = int.TryParse(entry, out centerNumber);

                    if (!success || centerNumber % 2 == 0 || centerNumber <= 0)
                    {
                        Console.WriteLine("------------------------------------------------------");
                        Console.WriteLine("Erro! Insira somente números ÍMPARES e INTEIROS.");
                        Console.WriteLine("------------------------------------------------------");
                        continue;
                    }
                           
                } while(!success || centerNumber % 2 == 0 || centerNumber <= 0);

                Console.WriteLine("Deseja criar um novo diamante? (S/N)");
                string toContinue = Console.ReadLine()!.ToUpper();
                if (toContinue != "S")
                    break;
            }
        }
    }
}
