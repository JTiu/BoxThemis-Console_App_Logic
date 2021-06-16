using System;
using System.Collections.Generic;
using System.IO;

namespace Boxing_Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeting.Instruction1();
            Greeting.Instruction2();
            //List of valid options for the scores, 7 to 10 only
           
            List<string> options = new List<string>();
            options.Add("7");
            options.Add("8");
            options.Add("9");
            options.Add("10");

            //Round 1
            string scoreBoxer1_1_str = Validation.StringOptions("Round #1: Boxer1 score: 10 or 9?", options);

            int scoreBoxer1_1 = Convert.ToInt32(scoreBoxer1_1_str);
            Console.WriteLine("");
            
            string scoreBoxer2_1_str = Validation.StringOptions("Round #1: Boxer2 score: 10 or 9?", options);

            int scoreBoxer2_1 = Convert.ToInt32(scoreBoxer2_1_str);
            Console.WriteLine("");

            Console.WriteLine("Boxer1 score: " + scoreBoxer1_1 + "; Boxer2 score: " + scoreBoxer2_1 + "\n");
            Console.WriteLine("");
            string round1Result = DetermineWinner.DisplayRoundWinner(scoreBoxer1_1, scoreBoxer2_1, 11);
            Console.WriteLine(round1Result);
            Console.ReadLine();
            Console.Clear();
            //Round 2
           
            Console.WriteLine("");

            string scoreBoxer1_2_str = Validation.StringOptions("Round #2: Boxer1 score: 10 or 9?", options);

            int scoreBoxer1_2 = Convert.ToInt32(scoreBoxer1_2_str);
            Console.WriteLine("");
            string scoreBoxer2_2_str = Validation.StringOptions("Round #2: Boxer2 score: 10 or 9?", options);

            int scoreBoxer2_2 = Convert.ToInt32(scoreBoxer2_2_str);
            Console.WriteLine("");

            Console.WriteLine("Boxer1 score: " + scoreBoxer1_2 + "; Boxer2 score " + scoreBoxer2_1);
            Console.WriteLine("");

            {
                if (scoreBoxer1_2 > scoreBoxer2_2)
                {
                    Console.WriteLine("Boxer1 won Round#2!");
                }
                else
                {
                    Console.WriteLine("Player2 won Round#2");
                }
            }
            Console.Clear();
           
            Console.WriteLine("");

            string scoreBoxer1_3_str = Validation.StringOptions("Round #3: Boxer1 score: 10 or 9?", options);

            int scoreBoxer1_3 = Convert.ToInt32(scoreBoxer1_3_str);
            Console.WriteLine("");

            Console.WriteLine("");

            string scoreBoxer2_3_str = Validation.StringOptions("Round #3: Boxer2 score: 10 or 9?", options);

            int scoreBoxer2_3 = Convert.ToInt32(scoreBoxer2_3_str);
            Console.WriteLine("");

            Console.WriteLine("Boxer1 score: " + scoreBoxer1_3 + "; Boxer2 score " + scoreBoxer2_3);
            Console.WriteLine("");
            Console.ReadLine();
            {
                
                if (scoreBoxer1_3 > scoreBoxer2_3)
                {
                    Console.WriteLine("Boxer1 won Round#3!");
                }
                else
                {
                    Console.WriteLine("Player2 won Round#3");
                }

            }
            Console.Clear();
            {
                Console.WriteLine("Let's determine the winner of the match:\n");
                int x = scoreBoxer1_1 + scoreBoxer1_2 + scoreBoxer1_3;
                int y = scoreBoxer2_1 + scoreBoxer2_2 + scoreBoxer2_3;
                
                if (x > y)
                {
                    Console.WriteLine("Boxer1's score = " + x + "\n\nBoxer2's score = " + y + "\n\nBoxer1 wins!");
                }
                else
                {
                    Console.WriteLine("Boxer1's score = " + x + "\n\nBoxer2's score = " + y + "\n\nBoxer2 wins!");
                    Console.WriteLine("\n");
                }
            }

            {
                int x_1 = scoreBoxer1_1;
                int x_2 = scoreBoxer1_2;
                int x_3 = scoreBoxer1_3;
                int x_4 = scoreBoxer2_1;
                int x_5 = scoreBoxer2_2;
                int x_6 = scoreBoxer2_3;
                int x_7 = scoreBoxer1_1 + scoreBoxer1_2 + scoreBoxer1_3;
                int x_8 = scoreBoxer2_1 + scoreBoxer2_2 + scoreBoxer2_3;


                PrintTable.PrintLine();
                PrintTable.PrintRow("Round 1", "Round 2", "Round 3", "Total");
                PrintTable.PrintLine();
                PrintTable.PrintRow("" + x_1, "" + x_2, "" + x_3, "" + x_7);
                PrintTable.PrintRow("" + x_4, "" + x_5, "" + x_6, "" + x_8);
                PrintTable.PrintLine();
                
                Console.ReadLine();
            }
        }
    }
}
