using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisKeyword
{
    internal class DeclareIndexer
    {
        private string[] name = new string[3];

        // declaring an indexer
        public string this[int index]
        {

            // returns value of array element
            get
            {
                return name[index];
            }

            // sets value of array element
            set
            {
                name[index] = value;
            }
        }
    }
}
