﻿using System;

namespace NumberGuessingGame // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            Random rng = new Random();
            int randomNumber = rng.Next(0, 100);
            Console.WriteLine("***********-Number Guessing Game-***********");
            Console.Write("Enter the Max number of guesses: ");
            input = Console.ReadLine();
            int maxGuesses = int.Parse(input);

            if(maxGuesses <= 0) {
                Console.WriteLine("The values for the max number of guesses must be a positive integer");
                return;
            }

            for(int i = 0; i < maxGuesses; i++) {
                Console.Write("Please enter a number between 1 and 100: ");
                input = Console.ReadLine();

                int guess = int.Parse(input);

                if(guess < 0){
                    Console.WriteLine("Your guess must be a positive integer");
                    continue;
                }

                int difference = randomNumber - guess;

                if(guess == randomNumber){
                    Console.WriteLine($"Correct, the number is {guess}");
                    return;
                } 

                if(difference >= -5 & difference <= 5){
                    Console.WriteLine("You're close");
                    continue;
                }

                if(guess < randomNumber){
                    Console.WriteLine("Guess was to low");
                }

                if(guess > randomNumber){
                    Console.WriteLine("Guess was to high");
                }
            }
        }
    }
}