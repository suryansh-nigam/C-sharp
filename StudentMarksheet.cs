using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your Roll no.");
            string roll = Console.ReadLine();

            Console.WriteLine("Enter your class"); 
            string standard = Console.ReadLine();

            Console.WriteLine("Enter english marks");
            int eng = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter maths marks");
            int maths = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter science marks");   
            int sci = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter history marks");
            int hist = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter hindi marks");
            int hindi = int.Parse(Console.ReadLine());

            Console.ReadLine();

            int total = eng + maths + sci + hist + hindi;
            float per = (total * 100 / 500);

            Console.WriteLine(" ---------  YOUR MARKSHEET  -----------");
            Console.WriteLine("Your Name is:{0} " , name);
            Console.WriteLine("Your Roll no. is:{0} " , roll);
            Console.WriteLine("Your class is:{0} " , standard);
            Console.WriteLine("Total marks are:{0} " , total);
            Console.WriteLine("Percentage is:{0} " , per);
            if(per >= 85)
            {
                Console.WriteLine("Congratulations! You are Excillent");
            }
            else if (per >= 75)
            {
                Console.WriteLine("Congratulations! You are First Division");
            }
            else if(per >= 50)
            {
                Console.WriteLine("Congratulations! You are Second Division");
            }
            else if(per >= 35)
            {
                Console.WriteLine("Congratulations! You are Third Division");
            }
            else
            {
                Console.WriteLine("Sorry! You are Fail ... work hard");
            }
            
        }
    }
}
