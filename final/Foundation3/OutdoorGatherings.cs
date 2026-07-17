public class OutdoorGathering: Event
{
    private string _weather;
    public OutdoorGathering(string title, string description, string date, string time, Address address, string weather)
        : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public string GetFullDetails()
    {
        return $"{EventDetails()}\n" + $"Event Type: Outdoor Gathering\n" + $"Weather Forecast: {_weather}";
    }

    public string MakeShortDescription()
    {
        return MakeShortDescription("Outdoor Gathering");
    }
}