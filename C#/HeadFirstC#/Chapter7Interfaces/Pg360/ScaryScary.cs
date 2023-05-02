using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pg360
{
    internal class ScaryScary : FunnyFunny, IScaryClown
    {
        private readonly int scaryThingCount;
        public string ScaryThingIHave
        {
            get { return Convert.ToString(scaryThingCount) + "spiders"; }
        }

        public ScaryScary(string funnyThing, int scaryCount) : base(funnyThing)
        {
            scaryThingCount= scaryCount;
        }

        public void ScareLittleChildren()
        {
            Console.WriteLine("Boo! Gotch! Look at my " + ScaryThingIHave);
        }
    }
}
