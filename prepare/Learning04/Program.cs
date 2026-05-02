using System;

class Program
{
    static void Main(string[] args)
    {
        int total = 0;
        int amount = 0;
        int highest = 0;
        string cont = "yes";
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        while (cont == "yes")
        {
            Console.Write("What number would you like to add? ");
            string input = Console.ReadLine();
            int addedNum = int.Parse(input);

            if (addedNum == 0)
            {
                Console.WriteLine("Thank you for the list of Numbers");
                cont = "no";
            }
            else
            {
                numbers.Add(addedNum);
            }
        }

        foreach (int number in numbers)
        {
            if (number > highest)
            {
                highest = number;
            }

            total += number;
            amount += 1;
        }

        int ave = total / amount;

        Console.WriteLine();
        Console.WriteLine($"The Sum of the number you input is {total}");
        Console.WriteLine($"The average of the numbers you input is {ave}");
        Console.WriteLine($"The highest number you input was {highest}");

    }
}