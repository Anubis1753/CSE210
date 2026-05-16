public class Journal
{
    // Attributes
    public List<Entry> _entries = new List<Entry>();

    private List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What was the most unexpected thing that happened today?",
        "What task did you have to do today that you wish you didnt?",
        "Where was the most interesting place you went today?"
    };

    // Behaviors
    public string AddEntry()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string randomPrompt = _prompts[index];
        Console.WriteLine($"Prompt: {randomPrompt}");
        Console.Write("> ");
        string inputResponse = Console.ReadLine();

        Entry newEntry = new Entry();
        
        DateTime theCurrentTime = DateTime.Now;
        newEntry._date = theCurrentTime.ToShortDateString();
        newEntry._prompt = randomPrompt;
        newEntry._response = inputResponse;

        _entries.Add(newEntry);
        Console.WriteLine("Entry Added");
        
        return "";
    }
    public void Display()
    {
        Console.WriteLine("--- Journal Entries ---");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveJournal()
    {
        Console.WriteLine("What is the name of the file you would like to save this as");
        Console.Write("> ");
        string fileName = Console.ReadLine();

        try
        {
            using (StreamWriter outputFile = new StreamWriter(fileName))
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}~|~{entry._prompt}~|~{entry._response}");
            }
            Console.WriteLine("Journal saved successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while saving: {ex.Message}");
        }
    }
    public void LoadJournal()
    {
        Console.Write("\nEnter filename to load: ");
        string fileName = Console.ReadLine();
        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found.");
            return;
        }
        try
        {
            _entries.Clear();
            string[] lines = File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                string[] parts = line.Split(new string[] { "~|~" }, StringSplitOptions.None);
                if (parts.Length == 3)
                {
                    Entry entry = new Entry
                    {
                        _date = parts[0],
                        _prompt = parts[1],
                        _response = parts[2]
                    };
                    _entries.Add(entry);
                }
            }
            Console.WriteLine("Journal loaded successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while loading: {ex.Message}");
        }
    }
}