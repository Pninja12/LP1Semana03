﻿using System;

namespace HeroPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            Perks perks = 0;

            bool broke = false;

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
                }

            }

        }
    }
}
