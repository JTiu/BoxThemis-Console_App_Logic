using System;
using System.Collections.Generic;
using System.IO;

namespace Boxing_Logic
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> options = new List<string>();
            options.Add("7");
            options.Add("8");
            options.Add("9");
            options.Add("10");
            Greeting.Instruction1();
            Greeting.Instruction2();
            RoundOne.SomethingMethod();
            RoundTwo.SomethingMethod();
            //List of valid options for the scores, 7 to 10 only
           
           
            //Round 1
           
            Console.Clear();
            
            //Round 2
            
            Console.Clear();
          //Round 3

            string scoreBoxer1_3_str = Validation.StringOptions("Round #3: Boxer1 score: 10 or 9?", options);

            int scoreBoxer1_3 = Convert.ToInt32(scoreBoxer1_3_str);
            
            Console.WriteLine("");
           
            string scoreBoxer2_3_str = Validation.StringOptions("Round #3: Boxer2 score: 10 or 9?", options);

            int scoreBoxer2_3 = Convert.ToInt32(scoreBoxer2_3_str);
            Console.WriteLine("");

            Console.WriteLine("Boxer1 score: " + scoreBoxer1_3 + "; Boxer2 score " + scoreBoxer2_3);
            string round3Result = DetermineWinnerRound_Overall.DisplayRoundWinner(scoreBoxer1_3, scoreBoxer2_3, 3);
            Console.WriteLine(round3Result);
            Console.ReadLine();
            
            Console.Clear();
            //Overall Winner
               
                //int x = scoreBoxer1_1 + scoreBoxer1_2 + scoreBoxer1_3;
                //int y = scoreBoxer2_1 + scoreBoxer2_2 + scoreBoxer2_3;
            
            //string overallWinner = DetermineWinnerRound_Overall.DisplayOverallWinner(x, y); 
            //Console.WriteLine(overallWinner);
           
                Console.ReadLine();
            {
                //int x_1 = scoreBoxer1_1;
                //int x_2 = scoreBoxer1_2;
                //int x_3 = scoreBoxer1_3;
                //int x_4 = scoreBoxer2_1;
                //int x_5 = scoreBoxer2_2;
                //int x_6 = scoreBoxer2_3;
                //int x_7 = scoreBoxer1_1 + scoreBoxer1_2 + scoreBoxer1_3;
                //int x_8 = scoreBoxer2_1 + scoreBoxer2_2 + scoreBoxer2_3;


                PrintTable.PrintLine();
                PrintTable.PrintRow("Round 1", "Round 2", "Round 3", "Total");
                PrintTable.PrintLine();
                //PrintTable.PrintRow("" + x_1, "" + x_2, "" + x_3, "" + x_7);
                //PrintTable.PrintRow("" + x_4, "" + x_5, "" + x_6, "" + x_8);
                PrintTable.PrintLine();

                Console.ReadLine();
            }
        }
    }
}
