using System;
using System.Collections.Generic;
using System.Text;

namespace Boxing_Logic
{
    public class RoundThree
    {
        public static void R3Method()
        {
            List<string> options = new List<string>();
            options.Add("7");
            options.Add("8");
            options.Add("9");
            options.Add("10");
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
        }
       
    }
}
