// using base instructions from: https://www.youtube.com/watch?v=ny5nIQMOkk0&list=PLm9GTh6TKrHOW8-eWabg6ETm95ajMid3b&index=2
using System;

namespace MiniGames.GameCode;

public class DiceRoll
{
    public static void Run()
    {
        Console.WriteLine("Welcome to Dice Roll!");

        int playerRandomNumber;
        int computerRandomNumber;

        int playerPoints = 0;
        int computerPoints = 0;

        Random random = new Random();

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine("Press any key to roll the dice...");
            Console.ReadKey();

            playerRandomNumber = random.Next(1, 7);
            Console.WriteLine($"You rolled: {playerRandomNumber}");

            Console.WriteLine("...");
            System.Threading.Thread.Sleep(1000);

            computerRandomNumber = random.Next(1, 7);
            Console.WriteLine($"Computer rolled: {computerRandomNumber}");


            if (playerRandomNumber > computerRandomNumber)
            {
                playerPoints++;
                Console.WriteLine("You win this round!");
            }
            else if (playerRandomNumber < computerRandomNumber)
            {
                computerPoints++;
                Console.WriteLine("Computer wins this round!");

            }
            else
            {
                Console.WriteLine("It's a tie!");
            }

            Console.WriteLine($"Score: You {playerPoints} - {computerPoints} Computer");
            Console.WriteLine();
        }

        if (playerPoints > computerPoints)
        {
            Console.WriteLine("You win the game!");
        }
        else if (playerPoints < computerPoints)
        {
            Console.WriteLine("Computer wins the game!");
        }
        else
        {
            Console.WriteLine("It's a tie!");
        }


    }

}
