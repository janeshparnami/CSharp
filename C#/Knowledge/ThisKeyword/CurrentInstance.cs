using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisKeyword
{
    internal class CurrentInstance
    {
        private int num;
        public CurrentInstance(int num)
        {
            this.num = num;
            Console.WriteLine("Inside the constructor: {0}", this);
        }
    }
}
