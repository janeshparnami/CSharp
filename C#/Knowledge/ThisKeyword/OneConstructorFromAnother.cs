using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisKeyword
{
    internal class OneConstructorFromAnother
    {
        private int num;
        private int num1;
        public OneConstructorFromAnother(int num) : this(num /2, num%10) {
            this.num = num;
            Console.WriteLine("Constructor with one parameter");
            Console.WriteLine($"this.num is : {this.num}");
        }
        public OneConstructorFromAnother(int num, int num1) {
            this.num = num;
            this.num1 = num1;
            Console.WriteLine("Constructor with 2 parameters");
            Console.WriteLine($"this.num is : {this.num}\n this.num1 is : {this.num1}");
        }
    }
}
