using System;

namespace Opgave1
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Indtast dit fornavn:");
                string firstName = Console.ReadLine();
                Console.WriteLine("Indtast dit efternavn:");
                string lastName = Console.ReadLine();
                string fullName = firstName + " " + lastName;
                Console.WriteLine($"\nDu hedder: {fullName}");
                string fullNameUpperCase = fullName.ToUpper();
                Console.WriteLine($"Alt med stort: {fullNameUpperCase}");
                string fullNameLowerCase = fullName.ToLower();
                Console.WriteLine($"Alt med småt: {fullNameLowerCase}");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
