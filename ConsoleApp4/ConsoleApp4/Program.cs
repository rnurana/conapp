using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! My name is Nani");
            Console.WriteLine("What is your name");
            string name=Console.ReadLine();
            Console.WriteLine("My name is {0}", name);

            Console.ReadKey();
        }
    }
}
