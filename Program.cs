using System;

namespace Exam
{
    class Program
    {
        public static void Main()
        {
            const string MsgStart = "Starting game!";
            const string MsgWin = "You win!";
            const string MsgLose = "You lose.";
            const string MsgFoundCoin = "You founded a coin. Coins: ";
            const string MsgFoundTrap = "You falled into a trap. Lives: ";

            int coins = 0;
            int lives = 3;

            var rand = new Random();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(MsgStart);
            Console.ResetColor();
            do
            {
                Thread.Sleep(1000);
                if (rand.Next(1, 3) == 1)
                {
                    lives--;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(MsgFoundTrap + lives);
                    Console.ResetColor();
                }
                else
                {
                    coins++;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(MsgFoundCoin + coins);
                    Console.ResetColor();
                }
            } while (!(lives == 0 || coins == 5));
            if (coins == 5)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(MsgWin);
                Console.ResetColor();
            } else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(MsgLose);
                Console.ResetColor();
            }
        }
    }
}