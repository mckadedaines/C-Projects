﻿using System;
using System.Collections.Generic;
using static System.Random;
using System.Text;


namespace Parachut {

    public class Program {

        private static void printParachutman(int wrong)
        {
            if(wrong == 0)
            {
               Console.WriteLine("\n+---+");
               Console.WriteLine("    |");
               Console.WriteLine("    |");
               Console.WriteLine("    |");
               Console.WriteLine("   ===");
            }
            else if(wrong == 1)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine("O   |");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
            }
            else if(wrong == 2)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine("O   |");
                Console.WriteLine("|   |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
            }
            else if(wrong == 3)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine(" O  |");
                Console.WriteLine("/|  |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
            }
            else if(wrong == 4)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine(" O  |");
                Console.WriteLine("/|\\ |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
            }
            else if(wrong == 5)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine(" O  |");
                Console.WriteLine("/|\\ |");
                Console.WriteLine("/   |");
                Console.WriteLine("   ===");
            }
            else if(wrong == 6)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine(" O  |");
                Console.WriteLine("/|\\ |");
                Console.WriteLine("/ \\ |");
                Console.WriteLine("   ===");
            }
        }

        private static int printWord(List<char>guessedLetters, String randomWord)
        {
            int counter = 0;
            int rightLetters = 0;
            Console.Write("\r\n");
            foreach (char c in randomWord)
            {
                if(guessedLetters.Contains(c))
                {
                    Console.Write(c + " ");
                    rightLetters++;
                }
                else
                {
                    Console.Write(" ");
                }
                counter++;
            }
            return rightLetters;
        }

        private static void printLines(String randomWord)
        {
            Console.Write("\r");
            foreach(char c in randomWord)
            {
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                Console.Write("\u0305 ");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Parachut game! :)");
            Console.WriteLine("-----------------------------------------");

            Random random = new Random();
            List<String> wordDictionary = new List<String> { "hello", "crazy", "automotive", "traveling", "explode", "welcome" };
            int index = random.Next(wordDictionary.Count);
            String randomWord = wordDictionary[index];

            foreach(char x in randomWord)
            {
                Console.Write("_ ");
            }

            int lengthOfWordToGuess = randomWord.Length;
            int amountOfTimesWrong = 0;
            List<char> currentLettersGuessed = new List<char>();
            int currentLettersRight = 0;

            while(amountOfTimesWrong != 6 && currentLettersRight != lengthOfWordToGuess)
            {
                Console.Write("\nLetters guessed so far: ");
                foreach(char letter in currentLettersGuessed)
                {
                    Console.Write(letter + " ");
                }
                // Prompt user for input
                Console.Write("\nGuess a letter: ");
                char letterGuessed = Console.ReadLine()[0];
                // Check if letter has already been guessed
                if(currentLettersGuessed.Contains(letterGuessed))
                {
                    Console.Write("\r\nYou have already guessed this letter.");
                    printParachutman(amountOfTimesWrong);
                    currentLettersRight = printWord(currentLettersGuessed, randomWord);
                    printLines(randomWord);
                }
                else
                {
                    // Check if letter is in the word
                    bool right = false;
                    for(int i = 0; i < randomWord.Length; i++) { if(letterGuessed == randomWord[i]) {right = true;}}

                       if(right)
                       {
                            printParachutman(amountOfTimesWrong);
                            currentLettersGuessed.Add(letterGuessed);
                            currentLettersRight = printWord(currentLettersGuessed, randomWord);
                            Console.Write("\r\n");
                            printLines(randomWord);
                       } 
                       else
                       {
                           amountOfTimesWrong++;
                           currentLettersGuessed.Add(letterGuessed);
                           printParachutman(amountOfTimesWrong);
                           currentLettersRight = printWord(currentLettersGuessed, randomWord);
                           Console.Write("\r\n");
                           printLines(randomWord);
                       }
                    
                }
            }
            Console.WriteLine("\r\nGame is over! Thank you for playing! :)");
         }
    }
}