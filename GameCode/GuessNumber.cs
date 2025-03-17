/* 
using base from: https://www.youtube.com/watch?v=Qs2aDQq8yWc&list=PLm9GTh6TKrHOW8-eWabg6ETm95ajMid3b&index=3 

Added a lock with combination of 3 numbers.
Added a loop to ask for a guess for each number in the lock.
Display unlocked lock with the guessed numbers.
 */

namespace MiniGames.GameCode;

public class GuessNumber
{
    public static void Run()
    {   Console.Clear();
        Console.WriteLine("Welcome to Guess The Number!");
        Console.WriteLine("Your goal is to unlock this lock by guessing numbers (each number is 1-9).");
        Console.WriteLine("If you guess all numbers correct, the lock will open and you win!");

        Random random = new Random();
        int[] lockCombination = { random.Next(1, 10), random.Next(1, 10), random.Next(1, 10) };
        int[] playerGuesses = { 0, 0, 0 };
        int[] attemptCounts = { 0, 0, 0 };
        int currentIndex = 0;

        DisplayLock(playerGuesses);

        while (currentIndex < 3)
        {
            while (true)
            {   // ask for input
                Console.Write($"\nEnter your guess for position {currentIndex + 1}: ");
                string? input = Console.ReadLine();

                // Validate user input and check if in range
                if (!int.TryParse(input, out int guess) || guess < 1 || guess > 9)
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 9.");
                    continue;
                }

                // count attempts
                attemptCounts[currentIndex]++;

                // check if guess is correct, tell if too high or low
                if (guess == lockCombination[currentIndex])
                {
                    playerGuesses[currentIndex] = guess;
                    DisplayLock(playerGuesses);
                    Console.WriteLine("Correct! You have unlocked this number.");
                    currentIndex++;
                    break;
                }
                else if (guess < lockCombination[currentIndex])
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else
                {
                    Console.WriteLine("Too high! Try again.");
                }

            }
        }
        // clear console and display unlocked lock
        Console.Clear();
        DisplayUnlocked(lockCombination);
        Console.WriteLine("\nCongratulations! You have successfully unlocked the lock!");
        Console.WriteLine($"\n  It took you a total of {attemptCounts.Sum()} guesses.");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"\t- {attemptCounts[i]} guesses for {i + 1}. number");
        }
    }

    // Display lock that updates with each correct guess 
    private static void DisplayLock(int[] guesses)
    {
        Console.WriteLine("        ╭───╮");
        Console.WriteLine("        │   │");
        Console.WriteLine("    ┌───┼───┼───┐");
        Console.WriteLine($"    │ {DisplaySlot(guesses[0])} │ {DisplaySlot(guesses[1])} │ {DisplaySlot(guesses[2])} │");
        Console.WriteLine("    └───┴───┴───┘");
    }

    // Display unlocked lock with correct numbers
    private static void DisplayUnlocked(int[] combination)
    {
        Console.WriteLine("        ╭───╮");
        Console.WriteLine("        │   ");
        Console.WriteLine("    ┌───┼───┼───┐");
        Console.WriteLine($"    │ {combination[0]} │ {combination[1]} │ {combination[2]} │");
        Console.WriteLine("    └───┴───┴───┘");
    }

    // Display number or ? for unknown number
    private static string DisplaySlot(int number)
    {
        return number == 0 ? "?" : number.ToString();
    }
}