using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumber = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (userNumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            string userResponse = Console.ReadLine();

            bool isValid = int.TryParse(userResponse, out userNumber);
            if (!isValid)
            {
                Console.WriteLine("Please enter a valid number.");
                continue;
            }

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        if (numbers.Count > 0)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            Console.WriteLine($"The sum is: {sum}");

            float average = (float)sum / numbers.Count;
            Console.WriteLine($"The average is: {average}");

            int max = numbers[0];
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            Console.WriteLine($"The max is: {max}");
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}