public class Reflection : Activity
{
    private List<string> _allPrompts = new List<string> { 
        "Think of a time when you stood up for someone else.", 
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless." 
    };
    private List<string> _availablePrompts;

    public Reflection()
    {
        _name = "Reflecting";
        _instruction = "This activity will help you reflect on times in your life when you have shown strength and resilience.";
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
        ShowSpinner(5);
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime) { ShowSpinner(3); }
        DisplayEndingMessege();
    }
}