using System;

// Tic-Tac-Toe game by Mckade Daines


// Turns out having a namespace and class are crucial to not having errors!
namespace TicTacToeGame
{
    class Program
    {
        // Main will create the array for the game markers and calls all the variables to run the code.
        static void Main(string[] args)
        {
            int gameStatus = 0;
            int currentPlayer = -1;
            char[] gameMarkers = {'1', '2', '3', '4', '5', '6', '7', '8', '9'};

            do {
                Console.Clear();

                currentPlayer = GetNextPlayer(currentPlayer);

                HeadsUpDisplay(currentPlayer);
                DrawGameboard(gameMarkers);

                GameEngine(gameMarkers, currentPlayer);

                gameStatus = checkWinner(gameMarkers);

            } while(gameStatus.Equals(0));

            Console.Clear();
            HeadsUpDisplay(currentPlayer);
            DrawGameboard(gameMarkers);

            if(gameStatus.Equals(1))
            {
                Console.WriteLine($"Player {currentPlayer} is the winner!!!");
            }

            if(gameStatus.Equals(2))
            {
                Console.WriteLine($"The game is a draw!");
            }
        }

        // Simple if statements to check for a winner or if its a draw
        private static int checkWinner(char[] gameMarkers)
        {
           if(IsGameDraw(gameMarkers))   
           {
               return 2;
           }  

           if(IsGameWinner(gameMarkers))
           {
               return 1;
           }
            return 0;
        }

        // Answer to draw results
        private static bool IsGameDraw(char[] gameMarkers)
        {
            return  gameMarkers[0] != '1' &&
                    gameMarkers[1] != '2' &&
                    gameMarkers[2] != '3' &&
                    gameMarkers[3] != '4' &&
                    gameMarkers[4] != '5' &&
                    gameMarkers[5] != '6' &&
                    gameMarkers[6] != '7' &&
                    gameMarkers[7] != '8' &&
                    gameMarkers[8] != '9';
        }

        // Answers to winner
        private static bool IsGameWinner(char[] gameMarkers)
        {
            if(IsGameMarkersTheSame(gameMarkers, 0, 1, 2))
            {
                return true;
            }

            if(IsGameMarkersTheSame(gameMarkers, 3, 4, 5))
            {
                return true;
            }

            if(IsGameMarkersTheSame(gameMarkers, 6, 7, 8))
            {
                return true;
            }

            if(IsGameMarkersTheSame(gameMarkers, 0, 3, 6))
            {
                return true;
            }

            if(IsGameMarkersTheSame(gameMarkers, 1, 4, 7))
            {
                return true;
            }

            if(IsGameMarkersTheSame(gameMarkers, 2, 5, 8))
            {
                return true;
            }

            if(IsGameMarkersTheSame(gameMarkers, 0, 4, 8))
            {
                return true;
            }

            if(IsGameMarkersTheSame(gameMarkers, 2, 4, 6))
            {
                return true;
            }

            return false;
        }

        // If the user enters anything higher than 9 it will correct them 
        // Will make sure the players cant overwrite each others answers
        private static bool IsGameMarkersTheSame(char[] testGameMarker, int pos1, int pos2, int pos3)
        {
            return (testGameMarker[pos1].Equals(testGameMarker[pos2]) && testGameMarker[pos2].Equals(testGameMarker[pos3]));
        }


        private static void GameEngine(char[] gameMarkers, int currentPlayer)
        {
            bool notValidMove = true;

            do 
            {
                string userInput = Console.ReadLine();
                if (!string.IsNullOrEmpty(userInput) && (userInput.Equals("1") || 
                    userInput.Equals("2") || 
                    userInput.Equals("3") || 
                    userInput.Equals("4") || 
                    userInput.Equals("5") || 
                    userInput.Equals("6") || 
                    userInput.Equals("7") || 
                    userInput.Equals("8") || 
                    userInput.Equals("9")))
                {
                    Console.Clear();

                    int.TryParse(userInput, out var gamePlacementMarkers);

                    char currentMarker = gameMarkers[gamePlacementMarkers - 1];

                    if(currentMarker.Equals('X') || currentMarker.Equals('O'))
                    {
                        Console.WriteLine("Placement has already a marker please select another placement.");
                    }
                    else
                    {
                        gameMarkers[gamePlacementMarkers - 1] = GetPlayerMarker(currentPlayer);
                        notValidMove = false;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid value please select another placement.");
                }
            } while(notValidMove);
        }

        // Simple math to replace the numbers players select with their corresponding answers
        private static char GetPlayerMarker(int player)
        {
            if(player % 2 == 0)
            {
                return 'O';
            }

            return 'X';
        }

        // Welcome screen and where the game begins
        static void HeadsUpDisplay(int PlayerNumber)
        {
            Console.WriteLine("Welcome to Tic Tac Toe!");

            Console.WriteLine("Player 1: X");
            Console.WriteLine("Plater 2: O");
            Console.WriteLine();

            Console.WriteLine($"Player {PlayerNumber} to move, select 1 through 9 from the game board.");
            Console.WriteLine();
        }

        // Draws the board that the players will play on
        static void DrawGameboard(char[] gameMakers)
        {
            Console.WriteLine($" {gameMakers[0]} | {gameMakers[1]} | {gameMakers[2]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {gameMakers[3]} | {gameMakers[4]} | {gameMakers[5]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {gameMakers[6]} | {gameMakers[7]} | {gameMakers[8]} ");
        }

        // Swaps between the 2 players each turn
        static int GetNextPlayer(int player)
        {
            if(player.Equals(1))
            {
                return 2;
            }

            return 1;
        }
    }
}
