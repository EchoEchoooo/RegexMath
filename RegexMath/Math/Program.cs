using System;

namespace Math
{
    static class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("======================================");
                Console.WriteLine("     Regex Math (By: Logic Gates)");
                Console.WriteLine("======================================");
                string input = Console.ReadLine();
                bool success = RegexMath.RegexMath.TryEvaluate(input, out double result);
                Console.WriteLine(success);
                if (success)
                    Console.WriteLine($"{input} = {result}");
                
                Console.WriteLine(" < Press any key to continue | Ctrl+X to exit > ");
                ConsoleKeyInfo keyInfo = Console.ReadKey();

                if (keyInfo.Modifiers == ConsoleModifiers.Control && keyInfo.Key == ConsoleKey.X)
                {
                    break;
                }
                Console.Clear();
            }

            Console.WriteLine("Regex Math (By: Logic Gates");
            Console.WriteLine("Members: ");
            Console.WriteLine("Geryko Luis Manarang");
            Console.WriteLine("Victoria Faye Babasa");
            Console.WriteLine("Jasmine Camasura");
            Console.WriteLine("Vincent Karl Murayama");
            Console.WriteLine("Kendric Ordoñez");
            
        }
    }
}
