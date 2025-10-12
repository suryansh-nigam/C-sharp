Q  - Write a program to check whether a number entered by the user is Even or Odd using the ternary operator.

==============================================================================================================

using System;

public class EvenOdd
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        
        string result = (number % 2 == 0) ? "Even" : "Odd";
        Console.WriteLine (result);
    }
}
