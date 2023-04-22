using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cabelo_Software.Business
{
    internal class Funcionario
    {
        private string name;
        public string userr;
        public string password;


        public void setName(string name) { this.name = name; }
        public string getName() { return this.name;}

        public void setUserr(string userr) { this.userr = userr; }
        public string getUserr() { return this.userr; }

        public void setPassword(string password) { this.password = password; }
        public string getUserPassword() { return this.password;}  
    }
}
