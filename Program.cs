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

            BoxerName boxer = new BoxerName();
            boxer.NameBoxer1 = Validation.String("What is the boxer one name?");
            boxer.NameBoxer2 = Validation.String("What is the boxer two name?");


            RoundResult round1Result  =  RoundOne.R1Method(); //need to replicate for rounds two and three
           //RoundTwo.R2Method();
            //RoundThree.R3Method();
            {
                
                PrintTable.PrintLine();
                PrintTable.PrintRow(   "BoxerName", "Round 1", "Round 2", "Round 3", "Total");
                PrintTable.PrintLine();
                PrintTable.PrintRow(boxer.NameBoxer1, round1Result.Boxer1Score.ToString(), "9", "" + "Z", "" + "M"); ;
               
                PrintTable.PrintLine();
                PrintTable.PrintLine();
                PrintTable.PrintRow("BoxerName", "Round 1", "Round 2", "Round 3", "Total");
                PrintTable.PrintLine();
                PrintTable.PrintRow("" + round1Result.Boxer2Score, "" + "77", "" + "Z", "" + "M");
                //PrintTable.PrintRow("" + x_4, "" + x_5, "" + x_6, "" + x_8);
                PrintTable.PrintLine();
                Console.ReadLine();

            }
        }
    }
}
