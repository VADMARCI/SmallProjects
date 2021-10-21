using System;
using System.Collections.Generic;

namespace RockPaperScissors_noGUI_
{
    class Program
    {
        static void Main(string[] args)
        {
            bool game = true;
            int playerPoints = 0;
            int computerPoints = 0;
            while (game == true)
            {
                Console.WriteLine("Type 1, 2 or 3 according to your choice!");
                Console.WriteLine("1 : Rock");
                Console.WriteLine("2 : Paper");
                Console.WriteLine("3 : Scissors");
                int input = Convert.ToInt32(Console.ReadLine());
                var rnd = new Random();
                int computer = rnd.Next(1, 4);
                switch (computer)
                {
                    case 1:
                        if (input == 1)
                        {
                            Console.WriteLine("It is a draw!");
                        }
                        else if (input == 2)
                        {
                            Console.WriteLine("You won!");
                            playerPoints++;
                        }
                        else if (input == 3)
                        {
                            Console.WriteLine("Computer won!");
                            computerPoints++;
                        }
                        break;
                    case 2:
                        if (input == 1)
                        {
                            Console.WriteLine("Computer won!");
                            computerPoints++;
                        }
                        else if (input == 2)
                        {
                            Console.WriteLine("It is a draw!");
                        }
                        else if (input == 3)
                        {
                            Console.WriteLine("You won!");
                            playerPoints++;
                        }
                        break;
                    case 3:
                        if (input == 1)
                        {
                            Console.WriteLine("You won!");
                            playerPoints++;
                        }
                        else if (input == 2)
                        {
                            Console.WriteLine("Computer won!");
                            computerPoints++;
                        }
                        else if (input == 3)
                        {
                            Console.WriteLine("It is a draw!");
                        }
                        break;
                }
                Console.WriteLine("Do you wish to play again?");
                Console.WriteLine("Enter Y or N");
                string answer = Console.ReadLine();
                if (answer == "N" || answer == "n")
                {
                    game = false;
                    Console.WriteLine("Player score: {0}", playerPoints);
                    Console.WriteLine("Computer score: {0}", computerPoints);
                    if (playerPoints > computerPoints)
                    {
                        Console.WriteLine("Player wins! :)");
                    }
                    else if (playerPoints == computerPoints)
                    {
                        Console.WriteLine("It is a draw! :|");
                    }
                    else
                    {
                        Console.WriteLine("Computer wins! :(");
                    }
                }

            }
            
        }

    }
}
