using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace TheLipBar
{
    public static class ShoppingCart
    {
        public static Dictionary<int, int> UserCart = new Dictionary<int, int>()
        {
            { 1, 0}, { 2, 0}, { 3, 0}, { 4, 0 }, {5,0},{6,0},{7,0},{8,0},{9,0},{10,0},{11,0},{12,0}
        };

        public static void GetOrder()
        {
            int userInput = Validator.GetInt("\nWhich number would you like? ");
            
            while (UserCart.ContainsKey(userInput) == false)
            {
                Console.WriteLine("\nSorry, that's not on the list. Please try again.");
                userInput = Validator.GetInt("\nWhich number would you like? ");
            }

            if (UserCart.ContainsKey(userInput))
            {
                UserCart[userInput] += 1;
                Console.WriteLine($"\nAdding #{userInput} {Inventory.InventoryDic[userInput].Name} to cart at {Inventory.InventoryDic[userInput].Price.ToString("C", CultureInfo.CurrentCulture)}");
            }
        }


    }
}
