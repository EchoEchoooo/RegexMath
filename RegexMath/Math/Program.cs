using System;

namespace Math
{
    static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("====== Main Menu ======");
            Console.WriteLine("1. Option 1");
            Console.WriteLine("2. Option 2");
            Console.WriteLine("3. Exit");

            bool isExit = false;
            do
            {
                string userOption = Console.ReadLine();
                switch (userOption)
                {
                    case "1":
                        Console.WriteLine("Addition an Subtraction\n");
                        Console.WriteLine("You have selected Option 1. Now, provide your implementation.\n");
                        string input = Console.ReadLine();
                        bool success = RegexMath.RegexMath.TryEvaluate(input, out double result);
                        Console.WriteLine(success);
                        if (success)
                            Console.WriteLine($"{input} = {result}");
                        break;
                    case "2":
                        Console.WriteLine("You have selected Option 2. Now, provide your implementation.");
                        // Your code for option 2 goes here
                        break;
                    case "3":
                        Console.WriteLine("============================================================================================");
                        Console.WriteLine("      T H A N K   Y O U   F O R   U S I N G   S T U D E N T   I N F O R M A T I O N !");
                        Console.WriteLine("============================================================================================");
                        Console.WriteLine("\n\t\t\tFinal Project in Automata Theory and Formal Languages");
                        Console.WriteLine("\t\t\t    Group Name: L O G I C   G A T E S\n");
                        Console.WriteLine("\n\t\t\tCreated by: ");
                        Console.WriteLine("\n\t\t\tManarang, Geryko Luis M. ");
                        Console.WriteLine("\n\t\t\tBabasa, Victoria Faye M.");
                        Console.WriteLine("\n\t\t\tCamasura, Jasmine M. ");
                        Console.WriteLine("\n\t\t\tMurayama, Vincent Karl M. ");
                        Console.WriteLine("\n\t\t\tOrdoñez, Kendric M. ");
                        Console.WriteLine("============================================================================");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please choose option from 1, 2 or 3");
                        break;
                }
            } while (!isExit);
        }
    }
}
