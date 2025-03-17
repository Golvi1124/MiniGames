namespace MiniGames;
using MiniGames.GameCode;

class Program
{
    static void Main(string[] args)
    {
        string? menuSelection;

        do
        {   
            try // needed try-catch because Debug Console in VS Code doesn't support Console.Clear() 
            {
                Console.Clear();
            }
            catch (IOException)
            {
                Console.WriteLine("Unable to clear the console in this environment.");
                //throw;
            }
            
            Console.WriteLine("Welcome to the Mini Games!");
            Console.WriteLine();
            Console.WriteLine("1. Dice Roll (against the computer)");
            Console.WriteLine("2. Guess The Number");
            Console.WriteLine("3. Rock, Paper, Scissors");
            Console.WriteLine("4. Tic Tac Toe");
            Console.WriteLine("5. The Hangman");

            Console.WriteLine();
            Console.Write("Enter your selection number (or type Exit to exit the program): ");

            menuSelection = Console.ReadLine()?.ToLower();

            switch (menuSelection)
            {
                case "1": 
                    DiceRoll.Run();
                    break;

                case "2": 
                    GuessNumber.Run();
                    break;

                case "3": // Rock, Paper, Scissors
                    Console.WriteLine("Here will be game code");
                    break;

                case "4": // Tic Tac Toe
                    Console.WriteLine("Here will be game code");
                    break;

                case "exit":
                    Console.WriteLine("Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        } while (menuSelection != "exit");
    }
}
