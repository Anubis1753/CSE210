public class Reception: Event
{
    private string _RSVP;

    public Reception(string title, string description, string date, string time, Address address, string RSVP)
        : base(title, description, date, time, address)
    {
        _RSVP = RSVP; 
    }

    public string GetFullDetails()
    {
        return $"{EventDetails()}\n" + $"Event Type: Reception\n" + $"RSVP: {_RSVP}";
    }

    public string MakeShortDescription()
    {
        return MakeShortDescription("Reception");
    }
}