using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace PandasMachine
{
    public class Chocolate : Product, IProduct
    {
        //initiering av konstruktor
        public Chocolate(string name, string description, string andvänd) : base(name, description, andvänd)
        {

        }

        //metod som används när du ska köpa produkten
        public bool Buy()
        {
            Console.WriteLine("Do you want to choose this product?");
            Console.WriteLine("yes or no");

            string svar = Console.ReadLine();

            if (svar == "yes")
            {
                Console.WriteLine("you have now bought a twix ");
                Console.WriteLine("you are now eating a twix, munch munch!");
                return true;
            }
            Console.Clear();
            return false;
        }
        //en "use" metod
        public void Use()
        {
            Console.WriteLine("you are now eating a twix, munch munch!");
        }

        // en metod för att beskriva produkten
        public void Description()
        {
            Console.WriteLine("delicioso chocolate bar");
        }
    }
}
