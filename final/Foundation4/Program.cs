using System;

class Program
{
    static void Main(string[] args)
    {
        Running R1 = new Running("03 Nov 2022", 30, 3.0);
        Cycling C1 = new Cycling("04 Nov 2022", 45, 15.0);
        Swimming S1 = new Swimming("05 Nov 2022", 20, 40);

        List<Activity> activities = new List<Activity>
        {
            R1, C1, S1
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}