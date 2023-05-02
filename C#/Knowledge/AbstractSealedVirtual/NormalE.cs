using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSealedVirtual
{
    internal class NormalE : NormalD
    {
        //This does not work because the class was sealed in NormalD
        //public override void CallMe()
        //{

        //}

        public override void CallMe1()
        {
            
            Console.WriteLine("Normal ClassE is called from CallMe1");
        }
    }
}
