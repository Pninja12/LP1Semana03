using System;

namespace HeroPerks
{
    class Program
    {
        /// <summary>
        /// Programa que recebe uma palavra e que dependente do conteudo, pode 
        /// cortar o programa, imprimir que não tem nada, ou imprimir as roles
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //variáveis
            Perks perks = 0;

            bool broke = false;

            //loop que vê letra a letra da string dada e atribui caso a letra 
            //dê certo ou para o programa se der errado
            foreach(char letra in args[0]){
                if (letra == 'w')
                    perks ^= Perks.WaterBreathing;
                else if (letra == 'a')
                    perks ^= Perks.AutoHeal;
                else if (letra == 's')
                    perks ^= Perks.Stealth;
                else if (letra == 'd')
                    perks ^= Perks.DoubleJump;
                else{
                    Console.WriteLine("Unknown perk!");
                    broke = true;
                    break;
                }

            }
            //caso o nenuma letra seja errada, então mostra que atributos o
            //jogador tem, caso tenha, e mostra outros extra que o jogador
            //pode ou não ter ou se tem alguma coisa se quer
            if (!broke)
            {
                if (perks == 0)
                {
                    Console.WriteLine("No perks at all!");
                }
                else
                {
                    Console.WriteLine(perks);
                }
                if ((perks & Perks.Stealth) == Perks.Stealth &&
                (perks & Perks.DoubleJump) == Perks.DoubleJump)
                {
                    Console.WriteLine("Silent jumper!");
                }
                if ((perks & Perks.AutoHeal) != Perks.AutoHeal)
                {
                    Console.WriteLine("Not gonna make it!");
                }
            }
        }
    }
}

