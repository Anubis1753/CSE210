using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(6);
        Fraction f3 = new Fraction(6 , 7);

        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimal());

        Fraction f4 = new Fraction();
        f4.SetTop(5);
        f4.SetBottom(1);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimal());

        Fraction f5 = new Fraction(2, 3);
        Console.WriteLine(f5.GetFractionString());
        Console.WriteLine(f5.GetDecimal());

        Fraction f6 = new Fraction(1, 3);
        Console.WriteLine(f6.GetFractionString());
        Console.WriteLine(f6.GetDecimal());

        Fraction f7 = new Fraction();
        Random random = new Random(); 
        for (int i = 1; i <= 20; i++)
        {
            int ranTop = random.Next(1, 101);
            int ranBottom = random.Next(1,101);

            f7.SetTop(ranTop);
            f7.SetBottom(ranBottom);

            Console.Write($"Fraction {i + 1}: ");
            Console.Write($"string: {f5.GetFractionString()}");
            Console.WriteLine($" Number: {f5.GetDecimal()}");
        }
    }
}