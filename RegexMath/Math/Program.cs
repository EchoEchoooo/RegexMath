using System;

namespace Math
{
    static class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Run run run kitty kitty run run bibidum bibidum bidibidubumbubm mygod");
                string input = Console.ReadLine();
                bool success = RegexMath.RegexMath.TryEvaluate(input, out double result);
                Console.WriteLine(success);
                if (success)
                    Console.WriteLine($"{input} = {result}");
            }
        }
    }
}