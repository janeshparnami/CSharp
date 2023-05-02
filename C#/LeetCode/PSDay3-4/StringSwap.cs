using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSDay3_4
{
    internal class StringSwap
    {
        int count = 2;
        int ind1;
        int ind2;
        public bool AreAlmostEqual(string s1, string s2)
        {
            List<char> charS1 = new List<char>(s1);
            List<char> charS2 = new List<char>(s2);

            for (int i = 0; i < s1.Length; i++)
            {
                if (charS1[i] != charS2[i])
                {
                    switch (count)
                    {
                        case 2:
                            ind1 = i;
                            break;
                        case 1:
                            ind2 = i;
                            break;
                        default:
                            return false;
                    }
                    count--;
                }
            }
            if (charS1[ind1] == charS2[ind2] && charS1[ind2] == charS2[ind1])
                return true;
            else
                return false;
        }
    }
}
