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
            string? input = Console.ReadLine();

            // Validate user input
            if (!int.TryParse(input, out playerGuess))
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 10.");
                continue; // Skip to the next loop iteration
            }
            // Check if the number is within the valid range
            if (playerGuess < 0 || playerGuess > 10)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 10.");
            }

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

/* 
Make it more interesting with:
- "imitate" lock with 3 numbers that needs to be guessed in order
- "Welcome to guess the number game!"
"Your goal is to unlock this lock by guessing numbers (each number is 1-9)"
and a lock something like this:
   _____
__|____|___
| ? | ? | ? |
____________



   _____
__|____|___
| 7 | ? | ? |
__________
Good job! You have guessed the first!
....
   _____
  |     |
__|__________
| 7 | 1 | 4 |
_____________
Congralations! You have succeded to unlock the lock!

 */