using System;

class Program
{
    static void Main(string[] args)
    {
        job job1 = new job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Google";
        job1._startYear = 2002;
        job1._endYear = 2025;

        job job2 = new job();
        job2._jobTitle = "Team Lead";
        job2._company = "Adobe";
        job2._startYear = 2005;
        job2._endYear = 2014;

        resume resume1 = new resume();
        resume1._name = "John";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();

    }
}