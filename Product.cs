using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PandasMachine
{
    public abstract class Product
    {
        //deklarerar variabler
        public string name;
        public string description;
        public string andvänd;

        // konstruktor

        public Product(string namn, string description, string andvänd  ) 
        {
            name = namn;
            this.description = description;
            andvänd = andvänd;
         
        }
    }
}
