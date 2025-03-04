using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250304__q4
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Hello";
            string name1 = "C# World";
            string name2 = "World";

            string message = greeting + "," + name1 + " " +name2 + "!";

            Console.WriteLine(message);

            Console.WriteLine(greeting + "," + name1.Replace("C#","CSharp")+" "+name2+"!");


        }
    }
}
