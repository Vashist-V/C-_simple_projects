using System;

namespace Number_guess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isCorrectGuess = false;
            Random random = new Random();
            int newRandom = random.Next(1, 101);

            Console.WriteLine("A number between 1 and 10 will be generated...");
            Console.WriteLine("If you guess the correct answer, You win the game");

            while(!isCorrectGuess)
            {
                Console.WriteLine("Please enter your number: ");
                int myNum = Convert.ToInt32(Console.ReadLine());

                if (myNum > newRandom)
                {
                    Console.WriteLine("Your guess is too high");
                }
                else if(myNum < newRandom)
                {
                    Console.WriteLine("You guess is too low");
                }
                else
                {
                    Console.WriteLine("Your guess is correct");
                    isCorrectGuess = true;
                }
                
            }

            Console.WriteLine("Congrats, you won the game!");
            Console.ReadKey();

        }
    }
}
