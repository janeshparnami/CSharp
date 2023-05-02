using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSealedVirtual
{
    internal class NormalD : NormalC
    {
        public sealed override void CallMe()
        {
            Console.WriteLine("Normal ClassD is called");
        }
        public override void CallMe1()
        {
            Console.WriteLine("Normal ClassD is called from CallMe1");
        }
    }
}
