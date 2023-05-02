using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualityOpVsEquals
{
    internal class StringTypes
    {
        string s1 = "Hello";
        string s2 = "hello";
        string s3;
        char[] values = { 'H', 'e', 'l', 'l', 'o' };
        string s4;
        object s5;

        public StringTypes() 
        {
            this.s3 = s1;
            this.s4 = new string(values);
            this.s5 = new string(values);

        }

        public void Compare()
        {
            Console.WriteLine(s1 == s3);
            Console.WriteLine(s1.Equals(s3));
            Console.WriteLine(s1 == s4);
            Console.WriteLine(s1.Equals(s4));
            Console.WriteLine(s1 == s5);
            Console.WriteLine(s1.Equals(s5));


        }

    }
}
