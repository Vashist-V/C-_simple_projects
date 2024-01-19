using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            float num1;
            float num2;
            string answer;

            float result;

            Console.WriteLine("Welcome to the calculator program");
            Console.WriteLine("Enter your first number");

            num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter your second number");

            num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("What type of operation you want to perform");

            Console.WriteLine("Please enter 'a' to perform addition, 's' to perform subtraction, 'm' to perform multiplication and press any other key to perform division");

            answer = Console.ReadLine();

            if(answer == "a")
            {
                result = num1 + num2;
            }
            else if(answer == "s")
            {
                result = num1 - num2;
            }
            else if (answer == "m")
            {
                result = num1 * num2;
            }
            else
            {
                if(num2 == 0)
                {
                    Console.WriteLine("Cannot divide by 0!");
                }
                else
                {
                    result = num1 / num2;
                }
            }

            Console.WriteLine("The result is " + result);
        }
    }
}
