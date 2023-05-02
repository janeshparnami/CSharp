using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{
    public class Rook : GenricClass<Queen>
    {
        public void Something()
        {
            _instance.DoSomething("I am Queen");
        }
    }
}
