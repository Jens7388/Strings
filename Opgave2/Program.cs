using System;

namespace Opgave2
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Skriv nogle bogstaver, og se hvor mange du har skrevet:");
                string letters = Console.ReadLine();
                if(letters.Length == 1)
                {
                    Console.WriteLine($"Du har skrevet 1 bogstav i alt");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine($"Du har skrevet {letters.Length} bogstaver i alt");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
    }
}
