// using keyword is a way to include namaspace from base class or user define class
using System;
// namespace is a member of another namespace, we have to specify the parent and child namespaces separated by a dot as follows:
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic; 
using System.Linq;

// System namespace as the Console class belongs to the System namespace.

namespace myApplication
{
    class Program
    {
        //The main() method is the entry point or starting point of the application to start its execution.
        static void Main(string[] arg)
        {
            Console.Title = "Hello from .NET Core on Ubuntu!";
            Console.WriteLine("Leraning Console Application");
            // Write - wrire string values
            // WriteLine -wrire  string values move cursor in new line 
            // ReadLine - read string values
            // Read - read a single character
            Console.WriteLine("Enter any charcater to see Read function fo Console class");
            //Console.WriteLine("Press any key ASCII value" + Console.Read());
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            Console.WriteLine("Enter your number");
            int Number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your number is {Number1}");


            //*****************************String class in C# ****************************
            // string is immutable means when we declare a  string aasign some value, and again reassign soem another value then it create a new memery
            // one object will be created which holds the value DotNet and that object will be referred to by the str variable. When the second statement will be executed,
            //another object will be created which holds the value Tutorials and now the str variable will point to this newly created object.first object will be there and will be available for garbage collectio
            string str="DOtnet";
            str="Tutorial"
            Console.WriteLine();

        }
    }
}

