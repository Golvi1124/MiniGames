namespace MiniGames;

class Program
{
    static void Main(string[] args)
    {
        string? menuSelection;

        do
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mini Games!");
            Console.WriteLine();
            Console.WriteLine("1. Dice Roll (against the computer)");
            Console.WriteLine("2. Guess the Number");
            Console.WriteLine("3. Rock, Paper, Scissors");
            Console.WriteLine("4. Tic Tac Toe");

            Console.WriteLine();
            Console.Write("Enter your selection number (or type Exit to exit the program): ");

            menuSelection = Console.ReadLine()?.ToLower();

            switch (menuSelection)
            {
                case "1": // Dice Roll
                    Console.WriteLine("Here will be game code");
                    break;

                case "2": // Guess the Number
                    Console.WriteLine("Here will be game code");
                    break;

                case "3": // Rock, Paper, Scissors
                    Console.WriteLine("Here will be game code");
                    break;

                case "4": // Tic Tac Toe
                    Console.WriteLine("Here will be game code");
                    break;

                case "exit":
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        } while (menuSelection != "exit");
    }
}
