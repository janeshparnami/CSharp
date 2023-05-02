using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hi_Lo
{
    internal class SecretAgent
    {
        private int id;
        private string name;
        private string password;

        public SecretAgent(int id , string name, string password) 
        { 
            this.id = id;
            this.name = name;
            this.password = password;
        }
    }
}
