using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();

        if (double.TryParse(input, out double number))
        {
            if (number > 0)
                Console.WriteLine("The number is Positive.");
            else if (number < 0)
                Console.WriteLine("The number is Negative.");
            else
                Console.WriteLine("The number is");
            double square = number * number;
            Console.WriteLine($"The square of {number} is {square}");
        }
        else
        {
            Console.WriteLine("Invalid input");
        }

        Console.WriteLine("Press any key");
        Console.ReadKey();
    }
}

