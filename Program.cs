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

            BoxerName_Weight askBoxerName_Weight = new BoxerName_Weight();
           askBoxerName_Weight.NameBoxer1 = Validation.String("What is boxer one's name?");
            askBoxerName_Weight.NameBoxer2 = Validation.String("What is boxer two's name?");
            askBoxerName_Weight.WeightBoxer1 = Validation.String($"What is {askBoxerName_Weight.NameBoxer1}'s weight?");
           askBoxerName_Weight.WeightBoxer2 = Validation.String($"What is {askBoxerName_Weight.NameBoxer2}'s weight?");

            

            RoundResult round1Result  =  RoundOne.R1Method(); //need to replicate for rounds two and three
           //RoundTwo.R2Method();
            //RoundThree.R3Method();
            {
                
                PrintTable.PrintLine();
                PrintTable.PrintRow(   "BoxerName", "Boxer Weight", "Round 1", "Round 2", "Round 3", "Total");
                PrintTable.PrintLine();
                PrintTable.PrintRow(askBoxerName_Weight.NameBoxer1, askBoxerName_Weight.WeightBoxer1, round1Result.Boxer1Score.ToString(), "99", "Z", "M"); ;
               
                PrintTable.PrintLine();
                PrintTable.PrintLine();
                PrintTable.PrintRow("BoxerName", "Boxer Weight", "Round 1", "Round 2", "Round 3", "Total");
                PrintTable.PrintLine();
                PrintTable.PrintRow(askBoxerName_Weight.NameBoxer2, askBoxerName_Weight.WeightBoxer2, round1Result.Boxer2Score.ToString(), "77", "Z", "M");
                //PrintTable.PrintRow("" + x_4, "" + x_5, "" + x_6, "" + x_8);
                PrintTable.PrintLine();
                Console.ReadLine();

            }
        }
    }
}
