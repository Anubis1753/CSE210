public class Comment
{
    string _name;
    string _words;

    public Comment(string name, string words)
    {
        _name = name;
        _words = words;
    }
    
    public void Display()
    {
        Console.WriteLine($"Name: {_name}, Comment: {_words}");
    }
}