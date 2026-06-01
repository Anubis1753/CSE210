using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Carl Roberts", "Chemistry");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Robert Carlson", "Cellular Division", "8.9", "12-27");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignments a3 = new WritingAssignments("Robertson Carl", "Stellar Creation", "The Birth of Stars");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInfo());
    }
}