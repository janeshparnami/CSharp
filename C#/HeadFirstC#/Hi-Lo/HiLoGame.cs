﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hi_Lo
{
    internal static class HiLoGame
    {
        public const int MAXIMUM = 10;
        private static Random random = new Random();
        private static int currentNumber = random.Next(1, MAXIMUM + 1);
        private static int pot = 10;

        public static int GetPot() { return pot; }

        public static void Guess(bool higher)
        {
            var nextNum = random.Next(1, MAXIMUM + 1);
            if((higher && nextNum >= currentNumber) || (!higher && nextNum <= currentNumber))
            {
                Console.WriteLine("You guessed right!");
                pot++;
            }
            else
            {
                Console.WriteLine("Bad luck, you guessed wrong.");
                pot--;
            }
            currentNumber = nextNum;
            Console.WriteLine("The current number is " + currentNumber);
        }
        public static void Hint()
        {
            var halfMax = MAXIMUM / 2;
            if (currentNumber >= halfMax)
                Console.WriteLine($"The number is atleast {halfMax}");
            else
                Console.WriteLine($"The number is at most {halfMax}");
            pot--;
        }
    }
}
