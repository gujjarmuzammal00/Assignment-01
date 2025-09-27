using System;

namespace Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your first name: ");
            string firstName = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(firstName))
            {
                Console.Write("Invalid input. Please enter your first name: ");
                firstName = Console.ReadLine();
            }

            Console.Write("Please enter your last name: ");
            string lastName = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(lastName))
            {
                Console.Write("Invalid input. Please enter your last name: ");
                lastName = Console.ReadLine();
            }

            // Trim spaces
            firstName = firstName.Trim();
            lastName = lastName.Trim();

            // Get initials
            char firstInitial = char.ToUpperInvariant(firstName[0]);
            char lastInitial = char.ToUpperInvariant(lastName[0]);

            // Output greeting
            Console.WriteLine($"Hello, {firstName} {lastName} ({firstInitial}.{lastInitial}.)");
        }
    }
}