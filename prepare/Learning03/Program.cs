using System;
using System.Collections.Concurrent;

class Program
{
    static void Main(string[] args)
    {
        Random randomnumbergenerator = new Random();
        int ranNum = randomnumbergenerator.Next(1,100);
        int guessNum = 0;

        string loop = "yes";

        Console.WriteLine("Guess an number between 1 and 100");

        while (loop == "yes")
        {
            Console.Write("What is the number you would like to guess: ");
            string input = Console.ReadLine();
            int guess = int.Parse(input);

            if (guess == ranNum)
            {
                Console.WriteLine("Congradulations you got it!");
                loop = "no";
                guessNum += 1;
                Console.WriteLine($"You guessed the correct number in {guessNum} guesses");
            }
            else if (guess > ranNum)
            {
                Console.WriteLine("Your guess was to high, try again");
                guessNum += 1;
            }
            else
            {
                Console.WriteLine("Your guess was too low, try again");
                guessNum += 1;
            }
        }

        
    }
}