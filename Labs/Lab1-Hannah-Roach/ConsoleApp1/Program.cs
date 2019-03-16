using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:\n");
            String name = Console.ReadLine();
            Console.WriteLine("\nPlease enter your age:\n");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nHello " + name + " you are " + age + " years old.");
            

        }
    }
}