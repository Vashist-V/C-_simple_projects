using System;

namespace areaCalculaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float result;
            string answer;

            Console.WriteLine("What shape would you like the find the area of?");
            Console.WriteLine("Please enter 'r' for rectangle or enter any other key to find area of circle");

            answer = Console.ReadLine();

            if(answer == "r")
            {
                Console.WriteLine("Enter the height of rectangle: ");
                float height = float.Parse(Console.ReadLine());

                Console.WriteLine("Enter the width of rectangle: ");
                float width = float.Parse(Console.ReadLine());

                result = height * width;
            }
            else
            {
                Console.WriteLine("Enter the radius of circle: ");
                float radius = float.Parse(Console.ReadLine());

                result = (float)Math.PI * (radius * radius);
            }
            Console.WriteLine("The answer is : " +  result);
            Console.ReadKey();
        }
        
    }
}
