using System;

namespace TheLipBar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Beauties!\n\nWELCOME TO THE LIP BAR!! \n");
            Console.WriteLine(new string('=', 107));

            Inventory.PrintInventory();
            do
            {
                ShoppingCart.GetOrder();

                
            } while(UserContinue());

            CashOut.PrintReceipt();

            //Inventory.PrintBasicInventory();

            
        }
        static bool UserContinue()
        {
            char key;
            do
            {
                Console.Write("\nWould you like anything else (y/n)? ");
                key = Console.ReadKey().KeyChar;
                key = char.ToLower(key);
                if (key == 'n')
                {
                    return false;
                }
                Console.WriteLine();

            } while (key != 'y');
            return true;
        }
    }
}
