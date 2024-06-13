using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string userNumber;
        int number = -1;

        List<int> numbers = new List<int>();

        while (number != 0)
        {
            Console.Write("Enter your number: ");
            userNumber = Console.ReadLine();
            number = int.Parse(userNumber);
            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        int sum = numbers.Sum();
        Console.WriteLine($"The total all the number is: {sum}");

        double average = numbers.Average();
        Console.WriteLine($"The average of the number is: {average}");

        int max = numbers.Max();
        Console.WriteLine($"The largest number is: {max}");
    }
}