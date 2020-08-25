using System;
using System.Collections.Generic;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Welcome to my number counting game...");
            Console.WriteLine();

            GuessNumber();
        }
        static void GuessNumber()
        {
            Console.WriteLine("How hard do you want to make this ?");
            Console.WriteLine("Level 1 = Easy @ 8 guesses");
            Console.WriteLine("Level 2 = Medium @ 6 guesses");
            Console.WriteLine("Level 3 = Hard @ 4 guesses");
            Console.WriteLine("Level 4 = Cheater @ to many guesses");
            Console.Write("Please choose difficulty level 1, 2, 3, or 4:  ");
            string difficulty = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"You Choose {difficulty}");
            int TotalGuesses = 0;
            if (difficulty == "1")
            {
                TotalGuesses = 8;
            }
            else if (difficulty == "2")
            {
                TotalGuesses = 6;
            }
            else if (difficulty == "3")
            {
                TotalGuesses = 4;
            }
            else if (difficulty == "4")
            {
                TotalGuesses = Int32.MaxValue;
            }

            // int TotalGuesses = 0;
            // switch (TotalGuesses)
            // {
            //     case 1:
            //         return 4;

            // }
            int GuessCounts = 0;
            int SecretNumber = new Random().Next(1, 101);

            while (GuessCounts < TotalGuesses)
            {
                Console.WriteLine($"This is guess number {GuessCounts +1}");
                Console.WriteLine("guess a number... any number, then hit enter");
                string Guess = Console.ReadLine();
                int IntGuess = Int32.Parse(Guess);
                Console.Clear();
                string SecretString = SecretNumber.ToString();

                if (Guess == SecretString)
                {
                    GuessCounts = GuessCounts + 1;
                    Console.WriteLine($"Thank you for entering your guess of {Guess}");
                    Console.WriteLine();
                    Console.WriteLine("Oh My Godz, you are right");
                    Console.WriteLine();
                    Console.WriteLine("... you arent one of those mutants?.. are you?");
                    Console.WriteLine($"You got that in only {GuessCounts} guesses");
                    break;

                }
                else
                {
                    GuessCounts = GuessCounts + 1;
                    Console.WriteLine($"Thank you for entering your guess of {Guess}");
                    Console.WriteLine("but sorry that was wrong.. guess again");
                    Console.WriteLine();
                    if (IntGuess < SecretNumber)
                    {
                        Console.WriteLine("Here is a hint... you were to Low");
                    }
                    else
                    {
                        Console.WriteLine("Here is a hint... you were to High");

                    }
                    Console.WriteLine();
                    Console.WriteLine($"That was your {GuessCounts} guess");
                    Console.WriteLine($"You have {TotalGuesses- GuessCounts} guesses left");

                    if (GuessCounts >= TotalGuesses)
                    {
                        Console.Clear();
                        Console.WriteLine($"sorry, you guessed {GuessCounts}x... and are our of guesses");
                        Console.WriteLine($"The Secret Number was {SecretString}");
                    }
                }
            }

        }

    }
}