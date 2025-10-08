using System;

Console.Write("Enter a string: ");
string input = Console.ReadLine();

if (string.IsNullOrEmpty(input))
{
    Console.WriteLine("Empty");
}
else if (string.IsNullOrWhiteSpace(input))
{
    Console.WriteLine("Whitespace");
}
else if (input.Length <= 10)
{
    Console.WriteLine("Short");
}
else
{
    Console.WriteLine("Long");
}