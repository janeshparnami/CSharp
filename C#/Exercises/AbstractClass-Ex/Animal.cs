using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_Ex
{
    internal abstract class Animal
    {
        public string Name { get; set; }
        //public void SetName(string name)
        //{

        //}
        //public void GetName()
        //{

        //}
        public abstract void Eat();
    }
}
