using System;
namespace MyFirstProgram
{
class Program
    {
        static void Main(string[] args)
        {
           Random random = new Random();
           int number = random.Next(1,100); 
           Console.Write("Guess a number between 100 and 1: ");
           int G =Convert.ToInt32(Console.ReadLine());
           while (G != number)
            {
                Console.Write("try again: ");
                G = Convert.ToInt32(Console.ReadLine());
                number = random.Next(1,100);
            }
            Console.WriteLine("You guessed the number!");
        }
    }
}
