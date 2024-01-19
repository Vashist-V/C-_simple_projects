using System;

namespace Dice_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int enemyRandomNum;

            int playerPoints = 0;
            int enemyPoints = 0;

            Random ramdom = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press any key to roll the dice");

                Console.ReadKey();

                playerRandomNum = ramdom.Next(1, 7);

                Console.WriteLine("You rolled a " +  playerRandomNum);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                enemyRandomNum = ramdom.Next(1, 7);

                Console.WriteLine("EnemyAI rolled a " +  enemyRandomNum);

                if(playerRandomNum > enemyRandomNum)
                {
                    playerPoints++;
                    Console.WriteLine("You win this round");
                }
                else if(playerRandomNum < enemyRandomNum)
                {
                    enemyPoints++;
                    Console.WriteLine("EnemyAI wins the round");
                }

                Console.WriteLine("The score is now Your points - " + playerPoints + ", Enemy points - " +  enemyPoints);
                Console.WriteLine();

            }
            if(playerPoints > enemyPoints)
            {
                Console.WriteLine("Congrats, You Won");
            }
            else if(enemyPoints > playerPoints)
            {
                Console.WriteLine("EnemyAI won the game");
            }
            else
            {
                Console.WriteLine("It's a draw");
            }
            Console.ReadKey();
        }
    }
}