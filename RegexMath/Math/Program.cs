using System;

namespace Math
{
    static class Program
    {
        private static void Main(string[] args)
        {
           while (true)
           {
               Console.ForegroundColor = ConsoleColor.Green;
               Console.WriteLine("======================================");
               Console.WriteLine("     Regex Math (By: Logic Gates)     ");
               Console.WriteLine("======================================");
           
               Console.ResetColor();
               var input = Console.ReadLine();
               var success = RegexMath.RegexMath.TryEvaluate(input, out var result);
               Console.WriteLine(success);
               if (success)
                   Console.WriteLine($"{input} = {result}");
           
               Console.ForegroundColor = ConsoleColor.Red;
               Console.WriteLine(" < Press any key to continue | Ctrl+X to exit > ");
               var keyInfo = Console.ReadKey();
           
               Console.Clear();
               if (keyInfo is { Modifiers: ConsoleModifiers.Control, Key: ConsoleKey.X }) break;
           }
           
           Console.ForegroundColor = ConsoleColor.Green;
           Console.WriteLine("======================================");
           Console.WriteLine("     Regex Math (By: Logic Gates)     ");
           Console.WriteLine("======================================");
           Console.WriteLine();
           Console.WriteLine("         ====== Members =====         ");
           Console.ResetColor();
           Console.WriteLine("         Geryko Luis Manarang         ");
           Console.WriteLine("         Victoria Faye Babasa         ");
           Console.WriteLine("           Jasmine Camasura           ");
           Console.WriteLine("         Vincent Karl Murayama        ");
           Console.WriteLine("            Kendric Ordoñez           ");
           
           Console.ReadKey();
        }
    }
}
