using System;
using System.Security.Cryptography;

class Program
{
    static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
    static string PromptUserName()
        {
            Console.Write("What is you Name? ");
            string name = Console.ReadLine();
            return name;
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string inputnum = Console.ReadLine();
            int num = int.Parse(inputnum);
            return num;
        }
        static int PromtUserBirthYear()
        {
            Console.Write("Please input the year you were born: ");
            string yearinput = Console.ReadLine();
            int birthday = int.Parse(yearinput);
            int age = 2026 - birthday;
            return age;
        }
         static int SquareNumber(int num)
        {
            int squared = num * num;
            return squared;
        }
        static void DisplayResult(string name, int squared, int age)
        {
            Console.WriteLine();
            Console.WriteLine($"{name}, the square of your number is {squared}");
            Console.WriteLine($"{name}, you will tun {age} this year.");
        }
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int num = PromptUserNumber();
        int age = PromtUserBirthYear();
        int squared = SquareNumber(num);
        DisplayResult(name, squared, age);
    }


}