Write a C# program to calculate the factorial of a given number using a for loop.
====================================================================================

using System;

public class factorial
{
    
    public static int Factorial(int n)
    {
        int f = 1;
        for (int i = 1; i <= n; i++)
        {
            f = f * i;
        }
        return f;
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int result = Factorial(number);
        Console.WriteLine("Factorial: " + result);
    }
}
