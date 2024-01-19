using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1;
            int num2;
            string answer;

            int result;

            Console.WriteLine("Welcome to the calculator program");
            Console.WriteLine("Enter your first number");

            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number");

            num2 = Convert.ToInt32(Console.ReadLine());

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
                result = num1 / num2;
            }

            Console.WriteLine("The result is " + result);
        }
    }
}