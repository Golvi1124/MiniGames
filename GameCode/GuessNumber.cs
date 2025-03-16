/* need to handle if user inputs not a number */

using System;

namespace MiniGames.GameCode;

public class GuessNumber
{
    public static void Run()
    {
        Console.WriteLine("Welcome to Guess the Number!");

        Random random = new Random();
        int numberToGuess = random.Next(1, 11);
        int playerGuess;
        int attempts = 0;

        Console.WriteLine("I'm thinking of a number between 1 and 10. Can you guess it?");

        do
        {
            Console.Write("\nEnter your guess: ");
            playerGuess = int.Parse(Console.ReadLine()!);
            attempts++;

            if (playerGuess < numberToGuess)
            {
                Console.WriteLine("Too low! Try again.");
            }
            else if (playerGuess > numberToGuess)
            {
                Console.WriteLine("Too high! Try again.");
            }
            else
            {
                Console.WriteLine($"Congratulations! {numberToGuess} is correct number! You guessed it in {attempts} attempts.");
            }
        } while (playerGuess != numberToGuess);
    }
}
