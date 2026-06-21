public class Activity
{
    protected string _name;
    protected string _instruction;
    protected double _duration;

    public void DisplayStartingMessege()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} activity.");
        Console.WriteLine();
        Console.WriteLine(_instruction);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    protected void DisplayEndingMessege()
    {
        Console.WriteLine();
        Console.WriteLine("Well Done!!!");
        ShowSpinner(3);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} activity");
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string> {"|", "/", "-", "\\", "|", "/", "-", "\\"};
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(animationStrings[i]);
            Thread.Sleep(500);
            Console.Write("\b \b");
            i++;
            if (i >= animationStrings.Count) i = 0;
        }
    }
}