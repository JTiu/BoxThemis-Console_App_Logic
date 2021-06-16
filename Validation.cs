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
    }
}
