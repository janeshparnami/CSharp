using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pg_449_Lumberjack
{
    public enum Flapjack
    {
        Crispy,
        Soggy,
        Browned,
        Banana,
    }

    internal class Lumberjack
    {
        public string Name { get; set; }
        private Stack<Flapjack> flapjackStack = new Stack<Flapjack>();
        public Lumberjack(string name)
        {
            this.Name = name;
        }
        public void TakeFlapjack(Flapjack fj)
        {
            flapjackStack.Push(fj);
        }
        public void EatFlapjack()
        {
            while(flapjackStack.Count > 0)
            {
                Flapjack fj =  flapjackStack.Pop();
                Console.WriteLine(fj);
            }
        }
    }
}
