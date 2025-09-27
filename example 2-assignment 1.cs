using System;

class Program
{
    static void Main()
    {
        int count = 0;
        int sum = 0;
        int evenCount = 0;
        int oddCount = 0;

        int min = 0;
        int max = 0;
        bool firstNumber = true;

        while (true)
        {
            Console.Write("Enter a number or press Enter to quit: ");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                break;
            }

            if (int.TryParse(input, out int number))
            {
                count++;
                sum += number;

                // Set min/max on first valid number
                if (firstNumber)
                {
                    min = max = number;
                    firstNumber = false;
                }
                else
                {
                    if (number < min) min = number;
                    if (number > max) max = number;
                }

                // Count even/odd
                if (number % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number or press Enter to quit.");
            }
        }

        if (count > 0)
        {
            double average = (double)sum / count;
            Console.WriteLine($"\nSummary:");
            Console.WriteLine($"Count   : {count}");
            Console.WriteLine($"Sum     : {sum}");
            Console.WriteLine($"Min     : {min}");
            Console.WriteLine($"Max     : {max}");
            Console.WriteLine($"Average : {average:F2}");
            Console.WriteLine($"Even    : {evenCount}");
            Console.WriteLine($"Odd     : {oddCount}");
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}