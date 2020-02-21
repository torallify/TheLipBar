using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace TheLipBar
{
    public static class CashOut
    {
        public static void PrintReceipt()
        {
            Console.Clear();
            //Console.ResetColor();
            //Console.Clear();
            //Console.BackgroundColor = ConsoleColor.White;
            //Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\nCASHIER: Riley Shirk");

            DateTime localDate = DateTime.Now;
            Console.WriteLine(localDate);

            Console.WriteLine("The Lip Bar");
            Console.WriteLine("1435 Farmer St Suite 122, Detroit, MI 48226");
            Console.WriteLine("(313) 506-9679 - www.thelipbar.com");
            Console.WriteLine("WELCOME TO THE SQUAD");
            Console.WriteLine(new string('-', 107));

            foreach (var kvPair in ShoppingCart.UserCart)
            {
                if (kvPair.Value > 0)
                {
                    Console.WriteLine($"{(kvPair.Value)} X {Inventory.InventoryDic[kvPair.Key].Name} ({(Inventory.InventoryDic[kvPair.Key].Price).ToString("C", CultureInfo.CurrentCulture)} each) = {((Inventory.InventoryDic[kvPair.Key].Price) * (kvPair.Value)).ToString("C", CultureInfo.CurrentCulture)}");
                }
            }

        }    
    }

}
