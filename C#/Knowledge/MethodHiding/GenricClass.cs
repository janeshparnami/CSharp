using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{
    public class GenricClass<T> where T : Pieces, new()
    {
        protected T _instance = new();

    }
}
