using System.Security.Cryptography.X509Certificates;

namespace PandasMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //deklarerar variabler och ger dom värde
            var fanta = new Drink("fanta", "one fizzy orange soda", " sip sip");
            var twix = new Chocolate("twix", "delicioso chocolate kex", "munch munch");
            var book = new Book("The hobbit", "this is a magical book on a miljon pages but totally worth it ", "read read");

            //initierar en loop för meny funktion
            bool isShopping = true;
            while (isShopping == true)
            {
                meny();

            }



            //funktion för meny 
            void meny()
            {
                Console.WriteLine("Welcome to the worlds worst but also best vendinge machine");
                Console.WriteLine("Kindly choose one of these premium products below");
                Console.WriteLine("PS. this is also a student friendly vender so everything is free ;)");
                Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨ ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");  
                Console.WriteLine($"1. {book.name}");
                Console.WriteLine($"2. {fanta.name}");
                Console.WriteLine($"3. {twix.name}");
                Console.WriteLine("Q. Quit");




                string val = Console.ReadLine();

                //en switch case för meny val
                switch (val.ToLower())
                {
                    case "1":
                        ChooseProduct(book);
                        
                        ResetMenu();
                        break;

                    case "3":
                        ChooseProduct(twix);
                        ResetMenu();
                        break;

                    case "2":
                        ChooseProduct(fanta);
                        ResetMenu();
                        break;

                    case "q":
                        isShopping = false;
                        Console.Clear();
                        Console.WriteLine("the program is now finished!");
                        break;
                    default:
                        Console.WriteLine("invalid selection, try again!");
                        ResetMenu();
                        break;


                }
            }
        }
        //funktioner som används för att "snygga" till koden
        private static void ChooseProduct(IProduct prod)
        {
            prod.Description();
            prod.Buy();
            
        }


        private static void ResetMenu()
        {
            Console.WriteLine("press any key to go back to meny");
            Console.ReadKey();
            Console.Clear();
        }
    }
}