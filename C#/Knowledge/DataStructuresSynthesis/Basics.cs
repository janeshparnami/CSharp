using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresSynthesis
{
    public static class Basics
    {
        public static int Multiply(int x)
        {
            return x % 2 == 0 ? x * 8 : x * 9;
        }
    }
}
