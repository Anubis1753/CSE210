public class Listing : Activity
{
    private List<string> _allPrompts = new List<string> { 
        "Who are people that you appreciate?", 
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?"
    };
    private List<string> _availablePrompts;

    public Listing()
    {
        _name = "Listing";
        _instruction = "This activity will help you reflect on the good things in your life by having you list as many things as you can.";
        _availablePrompts = new List<string>(_allPrompts);
    }

    public void Run()
    {
        DisplayStartingMessege();
        Random rand = new Random();

        if (_availablePrompts.Count == 0)
        {
            _availablePrompts = new List<string>(_allPrompts);
        }

        int index = rand.Next(_availablePrompts.Count);
        string prompt = _availablePrompts[index];
        _availablePrompts.RemoveAt(index);

        Console.WriteLine($"--- {prompt} ---");
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        int count = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }
        Console.WriteLine($"You listed {count} items!");
        DisplayEndingMessege();
    }
}