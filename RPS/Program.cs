using System;

namespace RPS
{
    class Program
    {
        /// <summary>
        /// Programa que recebe dois parâmetros do utilizador como duas escolhas
        /// do player1 e player2 para o jogo do Pedra,Papel,Tesoura.
        /// Mostrando no fim o vencedor
        /// </summary>
        /// <param name="args"></param>
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

        /// <summary>
        /// Função que determina o vencedor da partida entre os dois jogadores
        /// </summary>
        /// <param name="player1_s"></param>
        /// <param name="player2_s"></param>
        /// <returns></returns>
        private static int RockPaperScissors(string player1_s, string player2_s)
        {
            GameStatus status;

            //com ajuda do copilot
            //torna a escolha do jogador em um objeto do tipo GameItem para
            //ambos os jogadores
            GameItem player1 = (GameItem)Enum.Parse(typeof(GameItem),
            player1_s);
            GameItem player2 = (GameItem)Enum.Parse(typeof(GameItem),
            player2_s);
            
            //se ambos os players empatarem
            if (player1 == player2)
            {
                status = GameStatus.Draw; // Draw
            }
            //se o primeiro jogador ganhar
            //  -verifica se a diferença entre os dois jogadores é 1 ou -2
            //  caso não seja então o jogador 2 ganha no else em seguida
            else if (((int)player1 - (int)player2 == 1) ||
                ((int)player1 - (int)player2 == -2))
            {
                status = GameStatus.Player1Wins; // Player 1 wins
            }
            else
            {
                status = GameStatus.Player2Wins; // Player 2 wins
            }

            //retorna o tipo inteiro do GameStatus status
            return (int)status;
        }
    }
}
