using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Program // class
    {
        int a, b, c; // instance variable

        internal void accept()
        {
            Console.WriteLine("hello, please enter first number");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("hello, please enter second number");
            b = Convert.ToInt32(Console.ReadLine());
        }

        internal void add()
        {
            c = a + b;
            Console.WriteLine("the sum of two number is: " + c);
        }

        internal void sub()
        {
            c = a - b;
            Console.WriteLine("the subtraction of two number is: " + c);
        }

        internal void mul()
        {
            c = a * b;
            Console.WriteLine("the multiplication of two number is: " + c);
        }

        internal void div()
        {
            c = a / b;
            Console.WriteLine("the dividation of two number is:" + c);
        }

        static void Main(string[] args) // main method
        {
            Program op = new Program();
            op.accept();
            op.add();
            op.sub();
            op.mul();
            op.div();

            Console.ReadLine(); // Uncomment if you want to pause before exit
        }
    }
}

static void Main(string[] args) // main method
static → bina object banaye run ho jata hai.
void → kuch return nahi karta.
string[] args → command line arguments receive karta hai.

====================================
 Variables

int age = 20; // Integer variable
float b= 40.5f; // Float variable
char c = 'A'; // Character variable
string name = "Suryansh Nigam"; // String variable
bool isStudent = true; // Boolean variable
double d = 50.99d; // Double variable
long l = 1234567890L; // Long variable
byte by = 255; // Byte variable
short s = 32767; // Short variable

^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

Console.WriteLine("Hii, I am Suryansh  Nigam!");
Console.Write("My age is :" + age );
Console.WriteLine("I am a student:   " + isStudent);
Console.WriteLine("My name is: " + name);
Console.WriteLine("My character is: " + c); 
Console.WriteLine("My float value is: " + b);
Console.WriteLine("My double value is: " + d);
Console.WriteLine("My long value is: " + l);
Console.WriteLine("My byte value is: " + by);
Console.WriteLine("My short value is: " + s);

WriteLine() → Output print karta hai aur cursor next line pe chala jata hai.
Write() → Output print karta hai aur cursor same line pe rehta hai.

===========================================
Typecasting in C#

 convert one data type to another data type.
    1. Implicit Typecasting (Compiler Automatic convert, called safe conversion. "convert small to big datatypes" )
    2. Explicit Typecasting (Manually type, " bade datatype to small datatypes" )

 ===================================

-> Properties of C#

They use get (toread) and set (to write) accessors to define how values are accessed and modified.  
----------------------------------------------------------
-> what is tuple in C#? 

In C# , a tuple is a data structure that can hold a fixed number of items of different types. 
Tuples are useful for grouping related data together without creating a separate class or struct.
They are immutable, meaning that once a tuple is created, its values cannot be changed.

=================================================
 Access specifiers in C#
            
             1. Public: Accessible from any other class or assembly
                2. Private: Accessible only within the same class
                3. Protected: Accessible within the same class and its derived classes
                4. Internal: Accessible only within the same assembly
                5. Protected Internal: Accessible within the same assembly and from derived classes in other assemblies
                6. Private Protected: Accessible within the same class and derived classes within the same assembly
                
=======================================================

 what is linq in C#?
LINQ (Language Integrated Query) is a powerful feature in C# that allows you to query and manipulate data
 * from various sources, such as collections, databases, XML, and more, using a consistent syntax.
 * It provides a way to work with data in a more declarative and expressive manner.

 LINQ can be used with different data sources, including:
    1. LINQ to Objects: Querying in-memory collections like arrays, lists, and dictionaries.
    2. LINQ to SQL: Querying relational databases using SQL-like syntax.
    3. LINQ to XML: Querying and manipulating XML documents.
    4. LINQ to Entities: Querying Entity Framework data models.
    5. LINQ to DataSet: Querying DataSets and DataTables.
 

Console.ReadLine(); -  // ye line program ko tab tak run karne ke liye hai jab tak user enter nahi karta.



