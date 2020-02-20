using System;

namespace TheLipBar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Beauties!\nWELCOME TO THE LIP BAR!! \n");

            Inventory.PrintInventory();
            do
            {
                ShoppingCart.GetOrder();

            } while(UserContinue());
            Inventory.PrintBasicInventory();

            //test.PrintCars(out int addCarIndex, out int quitIndex, out int rangeCars);
        }
        static bool UserContinue()
        {
            char key;
            do
            {
                Console.Write("\nWould you like to continue (y/n)? <<");
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
