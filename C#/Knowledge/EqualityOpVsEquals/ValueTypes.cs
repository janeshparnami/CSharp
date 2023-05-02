using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualityOpVsEquals
{
    internal class ValueTypes
    {
        int a = 10;
        int b = 10;
        double c = 10.0;
        double d = 20.0;

        public void Compare() {

            Console.WriteLine(a == b);
            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a.Equals(c));
            Console.WriteLine(c == d);
            Console.WriteLine(c.Equals(d));

        }
    }
}
