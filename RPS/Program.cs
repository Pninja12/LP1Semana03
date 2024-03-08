using System;

namespace RPS
{
    class Program
    {
        private static void Main(string[] args)
        {
            int result = RockPaperScissors(args[0], args[1]);
            switch (result) 
            {
                case 0:
                    Console.WriteLine("It's a draw!");
                    break;
                case 1:
                    Console.WriteLine("Player 1 wins!");
                    break;
                case 2:
                    Console.WriteLine("Player 2 wins!");
                    break;
            }
        }

        private static int RockPaperScissors(string player1_s, string player2_s)
        {
            GameStatus status;

            //com ajuda do copilot
            GameItem player1 = (GameItem)Enum.Parse(typeof(GameItem),
            player1_s);
            GameItem player2 = (GameItem)Enum.Parse(typeof(GameItem),
            player2_s);

            if (player1 == player2)
            {
                status = GameStatus.Draw; // Draw
            }
            else if (((int)player1 - (int)player2 == 1) ||
                ((int)player1 - (int)player2 == -2))
            {
                status = GameStatus.Player1Wins; // Player 1 wins
            }
            else
            {
                status = GameStatus.Player2Wins; // Player 2 wins
            }

            return (int)status;
        }
    }
}
