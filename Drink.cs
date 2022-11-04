using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PandasMachine
{
    public class Drink : Product, IProduct
    {
        //initiering av konstruktor
        public Drink(string name, string description, string andvänd) : base(name, description, andvänd)
        {

        }

        //metod som används när du ska köpa produkten
        public bool Buy()
        {
            Console.WriteLine("Do you want to choose this product?");
            Console.WriteLine("yes or no ");

            string svar = Console.ReadLine();

            if (svar == "yes")
            {
                Console.WriteLine("you have now bought a fanta ");
                Console.WriteLine("you are now drinking a fanta , sip sip!");
                return true;
            }
            Console.Clear();
            return false;
        }

        //en "use" metod
        public void Use()
        {
            Console.WriteLine("you are now drinking a fanta , sip sip!");
            
        }

        // en metod för att beskriva produkten
        public void Description()
        {
            Console.WriteLine("one fizzy orange soda");
        }
        



    }
}
