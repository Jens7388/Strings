using System;

namespace Opgave4
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Skriv dit fornavn:");
                string firstName = Console.ReadLine();
                Console.WriteLine("Skriv dit efternavn:");
                string lastName = Console.ReadLine();
                string fullName = firstName + " " + lastName;
                string fullNameUpperCase = fullName.ToUpper();
                string fullNameLowerCase = fullName.ToLower();
                string initials = firstName.Substring(0, 1) + lastName.Substring(0, 1);
                Console.WriteLine($"Dit fulde navns længde: {fullName.Length - 1} ");
                Console.WriteLine($"Dit fulde navn med stort: {fullNameUpperCase}");
                Console.WriteLine($"Dit fulde navn med småt: {fullNameLowerCase}");
                Console.WriteLine($"Dine initialer: {initials}");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
