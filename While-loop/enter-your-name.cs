using System;
namespace MyFirstProgram
{
class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            while (name == "")
            {
                Console.Write("enter your name: ");
                name = Console.ReadLine();
            }

            Console.WriteLine("Hello " + name);
        }
    }
}
