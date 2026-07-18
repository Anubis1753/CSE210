using System;

class Program
{
    static void Main(string[] args)
    {
        Running RunningActivity = new Running("03 Nov 2022", 30, 3.0);
        Cycling CyclingActivity = new Cycling("04 Nov 2022", 45, 15.0);
        Swimming SwimmingActivity = new Swimming("05 Nov 2022", 20, 40);

        List<Activity> activities = new List<Activity>
        {
            RunningActivity, CyclingActivity, SwimmingActivity
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}