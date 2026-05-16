using System;

class Program
{
    static void Main(string[] args)
    {
        Entry entry = new Entry();
        DateTime theCurrentTime = DateTime.Now;
        entry._date = theCurrentTime.ToShortDateString();
        entry._prompt = "Insert cool prompt here";
        entry._response = "<Insert whatever the user typed here>";
        entry.Display();
    }
}