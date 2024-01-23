using System;

namespace NumberGuessingGame // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int RANGE_START = 0;
            const int RANGE_END = 100;
            const int CLOSE_GUESS_HIGH = 5;
            const int CLOSE_GUESS_LOW = -5;
            string input;
            Random rng = new Random();
            int randomNumber = rng.Next(RANGE_START, RANGE_END);
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

                if(guess < RANGE_START){
                    Console.WriteLine("Your guess must be a positive integer");
                    continue;
                }

                int difference = randomNumber - guess;

                if(guess == randomNumber){
                    Console.WriteLine($"Correct, the number is {guess}");
                    return;
                } 

                if(difference >= CLOSE_GUESS_LOW & difference <= CLOSE_GUESS_HIGH){
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