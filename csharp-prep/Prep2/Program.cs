using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What was the percent grade you got in this class? ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);
        string letter = "";
        string sign = "";
        string passed = "";
        char last = input[^1];
        int lastnum = (int)char.GetNumericValue(last);

        if (grade >= 90)
        {
            letter = "A";
            passed = "yes";
        }
        else if (grade >= 80)
        {
            letter = "B";
            passed = "yes";
        }
        else if (grade >= 70)
        {
            letter = "C";
            passed = "yes";
        }
        else if (grade >= 60)
        {
            letter = "D";
            passed = "no";
        }
        else
        {
            letter = "F";
            passed = "no";
        }

        if (lastnum >= 7)
        {
            sign = "+";
        }
        else if (lastnum >= 3)
        {
            sign = "";
        }
        else
        {
            sign = "-";
        }

        if (letter == "A" && sign == "+")
        {
            sign = "";
        }
        else if (letter == "F")
        {
            sign = "";
        }

        Console.WriteLine($"Your letter grade in this class was {letter}{sign}");

        if (passed == "yes")
        {
            Console.Write("Congradulations you passed the class!!");
        }
        else
        {
            Console.Write("You did not pass the class");
        }

    }
}