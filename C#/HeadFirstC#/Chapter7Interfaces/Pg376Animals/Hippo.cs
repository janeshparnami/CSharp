﻿namespace Pg376Animals
{
    internal partial class Program
    {
        class Hippo : Animal
        {
            public override void MakeNoise()
            {
                Console.WriteLine("Grunt.");
            }
            public void Swim()
            {
                Console.WriteLine("Splash! I'm going for a swim!");
            }
        }
    }
}