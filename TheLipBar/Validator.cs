using System;
using System.Collections.Generic;
using System.Text;

namespace TheLipBar
{
    public class Validator
    {
        static public int GetInt(string prompt)
        {
            string input;
            int number;
            bool worked;

            Console.Write(prompt);
            input = Console.ReadLine();
            worked = int.TryParse(input, out number);

            while (worked == false)
            {
                Console.WriteLine("Let's try again with a whole number ");
                Console.Write($"\n{prompt}");
                input = Console.ReadLine();

                worked = int.TryParse(input, out number);
            }
            return number;
        }
        static public double GetDouble(string prompt)
        {
            string input;
            double numberD;
            bool worked;

            Console.Write(prompt);
            input = Console.ReadLine();
            worked = Double.TryParse(input, out numberD);

            while (worked == false)
            {
                Console.WriteLine("Let's try again with a number.");
                Console.Write($"\n{prompt}");
                input = Console.ReadLine();

                worked = Double.TryParse(input, out numberD);
            }
            return numberD;
        }

    }
   
}
