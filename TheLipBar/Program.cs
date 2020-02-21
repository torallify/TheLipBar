using System;

namespace TheLipBar
{
    class Program
    {
        static void Main(string[] args)
        {

            var arr = new[]
           {
                    @" /$$$$$$$$ /$$                       /$$       /$$                 /$$$$$$$                      /$$",
                    @"|__  $$__/| $$                      | $$      |__/                | $$__  $$                    | $$",
                    @"   | $$   | $$$$$$$   /$$$$$$       | $$       /$$  /$$$$$$       | $$  \ $$  /$$$$$$   /$$$$$$ | $$",
                    @"   | $$   | $$__  $$ /$$__  $$      | $$      | $$ /$$__  $$      | $$$$$$$  |____  $$ /$$__  $$| $$",
                    @"   | $$   | $$  \ $$| $$$$$$$$      | $$      | $$| $$  \ $$      | $$__  $$  /$$$$$$$| $$  \__/|__/",
                    @"   | $$   | $$  | $$| $$_____/      | $$      | $$| $$  | $$      | $$  \ $$ /$$__  $$| $$          ",
                    @"   | $$   | $$  | $$|  $$$$$$$      | $$$$$$$$| $$| $$$$$$$/      | $$$$$$$/|  $$$$$$$| $$       /$$",
                    @"   |__/   |__/  |__/ \_______/      |________/|__/| $$____/       |_______/  \_______/|__/      |__/",
                    @"                                                  | $$                                              ",
                    @"                                                  | $$                                              ",
                    @"                                                  |__/                                              "
            };
            
            Console.WindowWidth = 130;
            foreach (string line in arr)
            {
                 Console.WriteLine(line);
            }
            Console.WriteLine();
 
           
            Console.WriteLine(new string('=', 107));
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
