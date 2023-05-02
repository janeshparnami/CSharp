using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisePg295
{
    internal class Pigeon : Bird
    {
        public string Color { get; private set; } = "White";
        private double size;
        public double Size
        {
            get { return size; }
            private set { size = value; }
        }

        public override Egg[] LayEggs(int numberOfEggs)
        {
            Egg[] eggs= new Egg[numberOfEggs];
            for (int i = 0; i < numberOfEggs; i++)
            {
                Size = SetSize();
                if (Bird.Randomizer.Next(4) == 0)
                    eggs[i] = new BrokenEgg("white");
                else
                    eggs[i] = new Egg(Size, "white");

            }
            return eggs;
        }
        private double SetSize()
        {
            double value = Math.Round(Randomizer.Next(1,3) + Randomizer.NextDouble(), 1, MidpointRounding.ToEven) ;
            return value;
        }
        public int NumOfLegs()
        {
            return 4;
        }
    }
}
