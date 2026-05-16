using System;

public class Entry
{
    // Attributes
    public string _date;
    public string _response;
    public string _prompt;

    // Behaviors, Called Methods
    public void Display()
    {
        Console.WriteLine($"{_date} -- {_prompt}");
        Console.WriteLine($"{_response}");
    }
}