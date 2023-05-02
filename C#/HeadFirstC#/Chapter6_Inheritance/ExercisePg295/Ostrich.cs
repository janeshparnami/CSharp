using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisePg295
{
    internal class Ostrich : Bird
    {
        public string Color { get; private set; } = "Speckled";
        private double size;
        public double Size
        {
            get { return size; }
            private set { size = value; }
        }
        private double SetSize()
        {
            double value = Math.Round(12 + Randomizer.NextDouble(), 1, MidpointRounding.ToEven);
            return value;
        }
        public override Egg[] LayEggs(int numberOfEggs)
        {
            Egg[] eggs = new Egg[numberOfEggs];
            for (int i = 0; i < numberOfEggs; i++)
            {
                Size = SetSize();
                Egg egg = new Egg(Size, Color);
                eggs[i] = egg;
            }
            return eggs;
        }
    }
}
