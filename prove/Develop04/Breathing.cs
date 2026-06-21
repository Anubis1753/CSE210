using System.Reflection.Metadata.Ecma335;

public class Breathing : Activity
{
    public Breathing()
    {
        _name = "Breathing";
        _instruction = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        DisplayStartingMessege();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in...");
            for (int i = 4; i > 0; i--)
            {
                Console.Write(i); 
                Thread.Sleep(1000);
                Console.Write("\b \b");
            } 
            Console.WriteLine(" ");

            Console.Write("Breathe out...");
            for (int i = 6; i > 0; i--)
            {
                Console.Write(i); 
                Thread.Sleep(1000);
                Console.Write("\b \b");
            } 
            Console.WriteLine("\n");
        }
        DisplayEndingMessege();
    }

}
    

