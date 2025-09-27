using System;

namespace TemperatureHistogram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of temperature readings: ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
                return;
            }

            int[] temps = new int[n];
            double sum = 0;
            int min = 0, max = 0;
            bool first = true;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter temperature reading {i + 1}: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int temp) || temp < -273)
                {
                    Console.WriteLine("Invalid input. Temperature must be a number >= -273.");
                    i--; // retry this index
                    continue;
                }

                temps[i] = temp;
                sum += temp;

                if (first)
                {
                    min = max = temp;
                    first = false;
                }
                else
                {
                    if (temp < min) min = temp;
                    if (temp > max) max = temp;
                }
            }

            double average = sum / n;
            Console.WriteLine($"\nMin: {min}°C");
            Console.WriteLine($"Max: {max}°C");
            Console.WriteLine($"Average: {average:F2}°C");

            // Create histogram
            int bucketWidth = 10;
            int bucketCount = ((max - min) / bucketWidth) + 1;
            int[] buckets = new int[bucketCount];

            foreach (int temp in temps)
            {
                int index = (temp - min) / bucketWidth;
                if (index >= 0 && index < buckets.Length)
                {
                    buckets[index]++;
                }
            }

            Console.WriteLine("\nTemperature Histogram:");
            for (int i = 0; i < buckets.Length; i++)
            {
                int rangeStart = min + i * bucketWidth;
                int rangeEnd = rangeStart + bucketWidth - 1;
                Console.WriteLine($"{rangeStart}°C to {rangeEnd}°C: {new string('*', buckets[i])}");
            }
        }
    }
}