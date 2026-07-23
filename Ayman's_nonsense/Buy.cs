using System;
namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            double Fprise = 0;
            double discount = 0;
           Console.Write("How many things do you want to buy: ");
           int Th = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("************************************************************************************************************************");
           Console.WriteLine("Enter the products value: ");
           for (int i = 0; i < Th; i++)
            {
             Console.Write(": ");
             int p = Convert.ToInt32(Console.ReadLine());
            total += p;
            }
            if (total >= 100)
            {
                discount = total * 0.10;
                Fprise = total - discount;
            Console.WriteLine("#################################################################################################################");
            Console.WriteLine("the total amount is: " + total);
            Console.WriteLine("The final price: " + Fprise);
            Console.WriteLine("The Discount amount: " + discount);
            Console.WriteLine("#################################################################################################################");
            }else
            {
            Console.WriteLine("#################################################################################################################");
            Console.WriteLine("the total amount is: " + total);
            Console.WriteLine("The final price: " + total);
            Console.WriteLine("no discount Applied");
            Console.WriteLine("#################################################################################################################");
            }
            
            }
        }
    }

