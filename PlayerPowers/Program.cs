using System;

namespace PlayerPowers
{
    class Program
    {
        /// <summary>
        /// Programa que pergunta quantos jogadores são e pede que poderes têm
        /// para no fim dizer quais poderes cada jogador tem
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Quantidade de jogadores
            Console.Write("Quantos jogadores queres?\n-> ");
            int n = int.Parse(Console.ReadLine());

            //Criação da lista de jogadores
            Powers[] players = new Powers[n];


            //Loop para dar poderes a cada jogador
            for(int i = 0; i < players.Length; i++)
            {
                //poderes a serem atribuidos no fim
                Powers currentchoice = 0;
                while(true)
                {
                    Console.Write($"Que poderes o {i+1}º personagem vai ter?");
                    Console.Write("\nPoderes disponíveis: ");
                    Console.WriteLine("Fly, XRayVision e SuperStrength");
                    Console.Write("-> ");
                    string resposta = Console.ReadLine();

                    if(resposta == "Fly")
                    {
                        currentchoice ^= Powers.Fly;
                    }
                    if(resposta == "XRayVision")
                    {
                        currentchoice ^= Powers.XRayVision;
                    }
                    if(resposta == "SuperStrength")
                    {
                        currentchoice ^= Powers.SuperStrength;
                    }
                    Console.Write("É só isso? (Sim para acabar/");
                    Console.Write("Não para continuar)\n->");
                    resposta = Console.ReadLine();

                    //Se a resposta for Sim, então dá os poderes ao jogador e
                    //vai para o próximo
                    if(resposta == "Sim"){
                        players[i] = currentchoice;
                        break;
                    }
                }
            }

            //Loop para mostrar todos os jogadores e os seus poderes
            for(int i = 0; i < players.Length; i++){
                Console.Write($"O {i + 1}ª Player tem: {players[i]}");
                // Verifica se o jogador tem o poder secreto
                if((players[i] & Powers.SuperStrength) == Powers.SuperStrength 
                && (players[i] & Powers.Fly) == Powers.Fly)
                {
                    Console.Write(", Flying radiation");
                }
                Console.WriteLine();
            }

        }
    }
} 