using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = ""; 
        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menue Options:\n 1. Start Breathing Activity\n 2. Start Relfection Activity\n 3. Start Listing Activity\n 4. Quit");
            Console.Write("Select a choice from the menue: ");
            choice = Console.ReadLine();

            if (choice == "1") new Breathing().Run();
            else if (choice == "2") new Reflection().Run();
            else if (choice == "3") new Listing().Run();
        }
    }
}
