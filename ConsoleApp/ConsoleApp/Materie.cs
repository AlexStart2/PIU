using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Materie
    {
        string name;
        public string getName { get { return name; } }
        public void setName(string _name)
        {
            if(_name.Equals("")||_name.Equals(null))
            {
                throw new Exception("Name should be defined");
            }
            name = _name;
        }

        public Materie() { }

    }
}
