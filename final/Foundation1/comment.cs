public class Comment
{
    string _name;
    string _words;

    public Comment(string name, string words)
    {
        name = _name;
        words = _words;
    }
    
    public void Display()
    {
        Console.WriteLine($"Name: {_name}, Comment: {_words}");
    }
}