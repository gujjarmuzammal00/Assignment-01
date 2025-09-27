using System;

namespace ProfileGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, city;
            int age;

            Console.Write("Enter your name: ");
            name = Console.ReadLine().Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Name cannot be empty or whitespace.");
                return;
            }

            Console.Write("Enter your age: ");
            string ageText = Console.ReadLine().Trim();
            if (!int.TryParse(ageText, out age) || age < 1 || age > 120)
            {
                Console.WriteLine("Age must be a number between 1 and 120.");
                return;
            }

            Console.Write("Enter your city: ");
            city = Console.ReadLine().Trim();
            if (string.IsNullOrWhiteSpace(city))
            {
                Console.WriteLine("City cannot be empty or whitespace.");
                return;
            }

            Console.WriteLine($"Name: {name}\nAge: {age}\nCity: {city}");
        }
    }
}