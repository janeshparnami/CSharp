using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSealedVirtual
{
    internal sealed class SealedB : AbstractA
    {
        public SealedB() { Console.WriteLine("Sealed Class constructor"); }
    }
}
