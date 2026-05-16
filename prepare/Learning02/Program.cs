using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Google";
        job1._startYear = 2002;
        job1._endYear = 2025;

        Job job2 = new Job();
        job2._jobTitle = "Team Lead";
        job2._company = "Adobe";
        job2._startYear = 2005;
        job2._endYear = 2014;

        Resume resume1 = new Resume();
        resume1._name = "John";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();

    }
}