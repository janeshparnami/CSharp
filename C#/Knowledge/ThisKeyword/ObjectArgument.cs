using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisKeyword
{
    internal class ObjectArgument
    {
        private int num;
        private int num1;
        private string name;

        public ObjectArgument(int num, int num1, string name)
        {
            this.num = num;
            this.num1 = num1;
            this.name = name;
        }
        public void Display()
        {
            PassParameter(this);
        }
        public void Display(ObjectArgument oa)
        {
            PassParameter(oa);
        }

        private void PassParameter(ObjectArgument objectArgument)
        {
            Console.WriteLine($"The name of the objet is {objectArgument.name} : {objectArgument.num}");
            Console.WriteLine($"The name of the objet is {objectArgument.name} :{objectArgument.num1}");
        }
    }
}
