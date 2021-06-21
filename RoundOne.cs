using System;
using System.Collections.Generic;
using System.Text;

namespace Boxing_Logic
{
    public static class RoundOne
    {
        public static string R1Method()
        {
            List<string> options = new List<string>();
            options.Add("7");
            options.Add("8");
            options.Add("9");
            options.Add("10");

            string scoreBoxer1_1_str = Validation.StringOptions("Round #1: Boxer1 score: 10 or 9?", options);

            int scoreBoxer1_1 = Convert.ToInt32(scoreBoxer1_1_str);
          

            string scoreBoxer2_1_str = Validation.StringOptions("Round #1: Boxer2 score: 10 or 9?", options);

            int scoreBoxer2_1 = Convert.ToInt32(scoreBoxer2_1_str);
            Console.WriteLine("");

            Console.WriteLine("Boxer1 score: " + scoreBoxer1_1 + "; Boxer2 score: " + scoreBoxer2_1 + "\n");
            Console.WriteLine("");
            string round1Result = DetermineWinnerRound_Overall.DisplayRoundWinner(scoreBoxer1_1, scoreBoxer2_1, 1);
            Console.WriteLine(round1Result);
            Console.ReadLine();
            string round1Display1 = scoreBoxer1_1_str;
            string round1Display2 = scoreBoxer2_1_str;
            
            return round1Display1;
            
        }
        


    }
}
