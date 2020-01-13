using System;

namespace Opgave3
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Skriv dit fornavn:");
                string firstName = Console.ReadLine();
                Console.WriteLine("Skriv dit efternavn");
                string lastName = Console.ReadLine();
                string initials = firstName.Substring(0, 1) + lastName.Substring(0, 1);
                Console.WriteLine($"Dine initialer er: {initials}");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
