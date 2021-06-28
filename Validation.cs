using System;
using System.Collections.Generic;
using System.Text;

namespace Boxing_Logic
{
    public static class Validation
    {
public static string StringOptions (string prompt, List <string> options)
        {
            Console.WriteLine(prompt);
            string result = Console.ReadLine();
            if (options.Contains(result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("Please try again");
                return StringOptions(prompt, options);
            }
        }
        public static string String(string prompt) //this will validate any string to ensure not empty
        {
            Console.WriteLine(prompt);
            string result = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("Please enter string only, no whitespace");
                return String(prompt);
            }
        }

    }
}
