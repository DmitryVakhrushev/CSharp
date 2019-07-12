using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgrammingAssignment5
{
    /// <summary>
    /// The program will play the game of War
    /// </summary>

    class Program
    {
        /// <summary>
        /// The program will play the game of War
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {
            // Set background color to DarkBlue
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            
            //Declare a variable for a random number generator and create a new Random object for that variable 
            Random rand = new Random();

            // Declare other variables as necessary to keep track of each player’s roll, each player’s number of wins
            // and whether or not we should play another game of War 
            int player1Roll, player1NumOfWins;
            int player2Roll, player2NumOfWins;

            int battleCount;
            string currentWin;
            bool play = true;

            //Print a "welcome" message
            Console.WriteLine("Welcome to War\n");

            // Play the the game again if the player wants another run
            do
            {
                // Set countes to 0
                player1NumOfWins = 0;
                player2NumOfWins = 0;
                battleCount = 0;

                while (battleCount <= 21)
                {
                    player1Roll = rand.Next(1, 7);
                    player2Roll = rand.Next(1, 7);

                    // Determine a Tie or Battle Winner
                    // Print the die values for the two players
                    if (player1Roll == player2Roll)
                    {
                        Console.WriteLine("   WAR!\t" + "P1:" + player1Roll + "\t" + "P2:" + player2Roll);
                    }

                    // Print which player won and increment that player’s win count
                    else
                    {
                        if (player1Roll > player2Roll)
                        {
                            player1NumOfWins++;
                            currentWin = "P1";
                        }
                        else
                        {
                            player2NumOfWins++;
                            currentWin = "P2";
                        }
                        Console.WriteLine("BATTLE:\t" + "P1:" + player1Roll + "\t" + "P2:" + player2Roll + "\t" + currentWin + " Wins!");
                        battleCount++;
                    }
                }

                //Print out which player won more battles
                if (player1NumOfWins > player2NumOfWins)
                {
                    Console.WriteLine("\nP1 is the overall Winner with " + player1NumOfWins + " battles!\n\n");
                }
                else
                {
                    Console.WriteLine("\nP2 is the overall Winner with " + player2NumOfWins + " battles!\n\n");
                }

                // Prompt for and get whether the player wants to play another game
                // Accept only 'n' or 'N' to end the program. Any other entry plays another game of War. 
                Console.Write("Do you want to play again? (y/n): ");
                char x = Console.ReadLine()[0];
                if (x == 'n' || x == 'N')
                {
                    play = false;
                }

            } while (play); // run the game again if it was not 'n' or 'N'

            // Print end of the game message
            Console.WriteLine("\nThank you for playing the game of War. Good bye!!!" + "\n\n");
        }
    }
}

