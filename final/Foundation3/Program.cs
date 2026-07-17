using System;

class Program
{
    static void Main(string[] args)
    {
        Address lectureAddress = new Address("100 University Ave", "Mapleton", "UT", "58678");
        Lecture myLecture = new Lecture("The Future of AI", "A deep dive into machine learning.", "October 12, 2026", "2:00 PM", lectureAddress, "Dr. Robert Roberton", 250);

        Address receptionAddress = new Address("4685 McCormic St", "Bakersfield", "CA", "93312");
        Reception myReception = new Reception("Tech Networking Night", "Meet industry professionals.", "November 5, 2026", "7:00 PM", receptionAddress, "rsvp@techevents.com");

        Address outdoorAddress = new Address("2986 Culver way", "Springville", "UT", "84658");
        OutdoorGathering myGathering = new OutdoorGathering("Summer Concert Series", "Live music in the park.", "July 24, 2026", "6:30 PM", outdoorAddress, "Sunny, 75°F with a light breeze");

        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("LECTURE MESSAGES");
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine(myLecture.EventDetails());
        Console.WriteLine("\n--- Full Details ---");
        Console.WriteLine(myLecture.GetFullDetails());
        Console.WriteLine("\n--- Short Description ---");
        Console.WriteLine(myLecture.MakeShortDescription());

        Console.WriteLine("\n\n-----------------------------------------");
        Console.WriteLine("RECEPTION MESSAGES");
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine(myReception.EventDetails());
        Console.WriteLine("\n--- Full Details ---");
        Console.WriteLine(myReception.GetFullDetails());
        Console.WriteLine("\n--- Short Description ---");
        Console.WriteLine(myReception.MakeShortDescription());

        Console.WriteLine("\n\n-----------------------------------------");
        Console.WriteLine("OUTDOOR GATHERING MESSAGES");
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine(myGathering.EventDetails());
        Console.WriteLine("\n--- Full Details ---");
        Console.WriteLine(myGathering.GetFullDetails());
        Console.WriteLine("\n--- Short Description ---");
        Console.WriteLine(myGathering.MakeShortDescription());
    }
}