using System;
using System.Collections.Generic;
using System.IO;

namespace Boxing_Logic
{
    public class Program
    {
        public static void Main(string[] args)
        { 
            
            Greeting.Instruction1();
            Greeting.Instruction2();

            
            RoundOne.R1Method();
            RoundTwo.R2Method();
            RoundThree.R3Method();
            {
               // string x_1 = RoundOne.R1Method();
                //string x_2 = RoundTwo.R2Method();
                //int x_2 = scoreBoxer1_2;
                //int x_3 = scoreBoxer1_3;
                //int x_4 = scoreBoxer2_1;
                //int x_5 = scoreBoxer2_2;
                //int x_6 = scoreBoxer2_3;
                //int x_7 = scoreBoxer1_1 + scoreBoxer1_2 + scoreBoxer1_3;
                //int x_8 = scoreBoxer2_1 + scoreBoxer2_2 + scoreBoxer2_3;

                
                Console.ReadLine();

                PrintTable.PrintLine();
                PrintTable.PrintRow("Round 1", "Round 2", "Round 3", "Total");
                PrintTable.PrintLine();
                PrintTable.PrintRow("" + "67", "" + "70", "" + "Z", "" + "M");
                //PrintTable.PrintRow("" + x_4, "" + x_5, "" + x_6, "" + x_8);
                PrintTable.PrintLine();

                Console.ReadLine();
            }
        }
    }
}
