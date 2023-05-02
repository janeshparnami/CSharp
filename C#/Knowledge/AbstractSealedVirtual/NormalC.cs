using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSealedVirtual
{
    internal class NormalC
    {
        public virtual void CallMe()
        {
            Console.WriteLine("Normal ClassC is called");
        }

        public virtual void CallMe1() { Console.WriteLine("Normal ClassC is called from CallMe1"); }
    }
}
