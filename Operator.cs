using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // arithmetic operators
            int a = 10, b = 23;
            Console.WriteLine("Arithmetic operators");

            Console.WriteLine(a+b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a / b * b);
            Console.WriteLine(a % b);
            Console.WriteLine(++a);
            Console.WriteLine(--b);
            Console.WriteLine(a++);
            Console.WriteLine(b--);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine();


            // relational operators
            Console.WriteLine("Relational operators");
            Console.WriteLine(a > b);
            Console.WriteLine(a >= b);
            Console.WriteLine(a <= b);
            Console.WriteLine(a < b);
            Console.WriteLine(a != b);
            Console.WriteLine(a == b);
            Console.WriteLine();

            // logical operators
            Console.WriteLine("Logical operators");
            Console.WriteLine((a > b) && (a != b));
            Console.WriteLine((a > b) || (a != b));
            Console.WriteLine(!(a > b));
            Console.WriteLine();

            // bitwise operators
            Console.WriteLine("Bitwise operators");
            Console.WriteLine(a^b);
            Console.WriteLine(a|b);
            Console.WriteLine(a&b);
            Console.WriteLine(~a);
            Console.WriteLine(~b);
            Console.WriteLine(a<<2);
            Console.WriteLine(b>>2);
            Console.WriteLine(b<<1);
            Console.WriteLine(a>>1);
            Console.WriteLine();

            // assignment operators
            Console.WriteLine("Assignment operators");
            Console.WriteLine(a == b);
            Console.WriteLine(a += b);
            Console.WriteLine(a /= b);
            Console.WriteLine(a -= b);
            Console.WriteLine(a <= b);
            Console.WriteLine(a %= b);
            Console.WriteLine(a *= b);
            Console.WriteLine(a != b);
            Console.WriteLine();

            // ternary operator
            Console.WriteLine("Ternary operator");
            Console.WriteLine(a > b ? a : b);
            Console.WriteLine();

       }
    }
}
