using System;

Console.WriteLine("Welcome to Tic-Tac-Toe!");

Console.WriteLine("Please choose a spot (1-9): ");
string answer1 = Console.ReadLine();
int player1 = int.Parse(answer1);

// List<char> result = new List<char>();
// Static char [] result = (0, 1, 2, 3, 4, 5, 6, 7, 8, 9);
 static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
