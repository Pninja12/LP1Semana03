using System;

namespace PlayerPowers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos jogadores queres?\n-> ");
            int n = int.Parse(Console.ReadLine());

            Powers[] players = new Powers[n];

            for(int i = 0; i < players.Length; i++)
            {
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

                    if(resposta == "Sim"){
                        players[i] = currentchoice;
                        break;
                    }
                }
            }

            for(int i = 0; i < players.Length; i++){
                Console.Write($"O {i + 1}ª Player tem: {players[i]}");
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