public class Video
{
    public string _videoTitle;
    public string _videoAuthor;
    public int _lengthSeconds;

    private List<Comment> _comments = new List<Comment>();

    public Video(string videoTitle, string videoAuthor, int lengthSeconds)
    {
        _videoTitle = videoTitle;
        _videoAuthor = videoAuthor;
        _lengthSeconds = lengthSeconds;
    }

    public void NewComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int NumComments()
    {
        return _comments.Count;
    }

    public void Display()
    {
        Console.WriteLine($"Title: {_videoTitle}");
        Console.WriteLine($"Author: {_videoAuthor}");
        Console.WriteLine($"Length: {_lengthSeconds} seconds");
        Console.WriteLine($"Comments ({NumComments()}):");

        foreach (Comment c in _comments)
        {
            c.Display();
        }
        Console.WriteLine();

    }
}