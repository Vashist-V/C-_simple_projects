using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_paper_scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int playerScore = 0;
            int enemyScore = 0;

            Console.WriteLine("Welcome to Rock, Paper, Scissors game");

            while(playerScore != 3 && enemyScore != 3)
            {
                Console.WriteLine("Player score - " +  playerScore + " | enemy score - " + enemyScore);
                Console.WriteLine("Please enter 'r' for rock, 'p' for paper and 's' for scissor");
                string playerChoice = Console.ReadLine();

                int enemyChoice = random.Next(0, 3);

                if(enemyChoice == 0 )
                {
                    Console.WriteLine("Enemy chooses rock");

                    switch(playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Tie");
                            break;
                        case "p":
                            Console.WriteLine("You win");
                            playerScore++;
                            break;
                        case "s":
                            Console.WriteLine("You lose");
                            playerScore--;
                            break;
                    }
                }
                else if(enemyChoice == 1 )
                {
                    Console.WriteLine("Enemy chooses paper");

                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("You lose");
                            playerScore--;
                            break;
                        case "p":
                            Console.WriteLine("Tie");
                            break;
                        case "s":
                            Console.WriteLine("You win");
                            playerScore++;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Enemy chooses scissor");

                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("You win");
                            playerScore++;
                            break;
                        case "p":
                            Console.WriteLine("You lose");
                            playerScore--;
                            break;
                        case "s":
                            Console.WriteLine("Tie");
                            break;
                    }
                }
            }
            if(playerScore == 3 )
            {
                Console.WriteLine("Congrats you won the match");
            }
            else
            {
                Console.WriteLine("Alas, you lost the match");
            }

            Console.ReadKey();
        }
    }
}
