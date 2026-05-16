using System;

class Program
{
    static void Main(string[] args)
    {
        Journal newJournal = new Journal();
        string choice = "";

        Console.WriteLine("Welcome to your Journal!");
        while(choice != "5")
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Load the journal from a file");
            Console.WriteLine("4. Save the journal to a file");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do? ");
            Console.Write("> ");
            choice = Console.ReadLine();

            switch(choice)
            {
                case "1":
                    newJournal.AddEntry();
                    break;
                case "2":
                    newJournal.Display();
                    break;
                case "3":
                    newJournal.LoadJournal();
                    break;
                case "4":
                    newJournal.SaveJournal();
                    break;
                case "5":
                    Console.WriteLine("\nGoodbye!");
                    break;
                default:
                    Console.WriteLine("\nInvalid option. Please choose a number from 1 to 5.");
                    break;
            }
        }
    }
}