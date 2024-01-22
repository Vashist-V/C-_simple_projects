using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace currency_temp_conv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome, please enter 'c' to use currency converter or enter any other key to use temperature converter");
            string answer = Console.ReadLine();

            if(answer == "c")
            {
                Console.WriteLine("You have selected currency converter");
                Console.WriteLine("Enter 'u' to convert from usd to inr or any other key to perform vice versa");

                string choice1 = Console.ReadLine();

                if(choice1 == "u")
                {
                    Console.WriteLine("Enter the value in USD...");
                    float usd = float.Parse(Console.ReadLine());
                    float inr = usd * 0.012f;
                    Console.WriteLine("The amount in INR is " + inr.ToString("0.00"));
                }
                else
                {
                    Console.WriteLine("Enter the value in INR...");
                    float inr = float.Parse(Console.ReadLine());
                    float usd = inr / 83.07f;
                    Console.WriteLine("The amount in USD is " + usd.ToString("0.00"));
                }
            }

            else
            {
                Console.WriteLine("You have selected weight converter");
                Console.WriteLine("Enter 'p' to convert from pounds to Kilogram or any other key to perform vice versa");

                string choice1 = Console.ReadLine();

                if (choice1 == "p")
                {
                    Console.WriteLine("Enter the value in Pounds...");
                    float pounds = float.Parse(Console.ReadLine());
                    float kg = pounds * 0.453592f;
                    Console.WriteLine("The weight in kilogram is " + kg.ToString("0.00"));
                }
                else
                {
                    Console.WriteLine("Enter the value in kilogram...");
                    float kg = float.Parse(Console.ReadLine());
                    float pounds = kg * 2.204f;
                    Console.WriteLine("The weight in pounds is " + pounds.ToString("0.00"));
                }
            }

            Console.ReadKey();
        }
    }
}
