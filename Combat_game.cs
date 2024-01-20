using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combat_based_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerHp = 40;
            int enemyHp = 20;

            int playerAttack = 5;
            int enemyAttack = 7;

            int healAmount = 5;
            Random random = new Random();

            while(playerHp > 0 && enemyHp>0)
            {
                Console.WriteLine("--Player Turn--");
                Console.WriteLine("Player hp - " + playerHp + " | Enemy hp - " + enemyHp);
                Console.WriteLine("Enter 'a' to attack and 'h' to heal");

                string choice = Console.ReadLine();
                if (choice == "a")
                {
                    enemyHp = enemyHp - playerAttack;
                    Console.WriteLine("Player attacks enemy and deals " + playerAttack + " damage.");
                }
                else
                {
                    playerHp = playerHp + healAmount;
                    Console.WriteLine("Player restores " + healAmount + " health points");
                }

                if(enemyHp > 0)
                {
                    Console.WriteLine("--Enemy Turn--");
                    Console.WriteLine("Player hp - " + playerHp + " | Enemy hp - " + enemyHp);
                    int enemyChoice = random.Next(0, 2);

                    if(enemyChoice == 0)
                    {
                        playerHp = playerHp - enemyAttack;
                        Console.WriteLine("Enemy attacks enemy and deals " + enemyAttack + " damage.");
                    }
                    else
                    {
                        enemyHp = enemyHp + healAmount;
                        Console.WriteLine("Enemy restores " + healAmount + " health points");
                    }
                }
            }
            
            if(playerHp > 0)
            {
                Console.WriteLine("Congrats, you won!");
            }
            else
            {
                Console.WriteLine("You lose!");
            }

            Console.ReadKey();
        }
    }
}
