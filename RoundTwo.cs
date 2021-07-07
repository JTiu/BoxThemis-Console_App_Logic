using System;
using System.Collections.Generic;
using System.Text;

namespace Boxing_Logic
{
    public static class RoundTwo
    {
        public static string R2Method()
        {
            List<string> options = new List<string>();
            options.Add("7");
            options.Add("8");
            options.Add("9");
            options.Add("10");

            string scoreBoxer1_2_str = Validation.StringOptions("Round #2: Boxer1 score: 10 or 9?", options);

            int scoreBoxer1_2 = Convert.ToInt32(scoreBoxer1_2_str);
            Console.WriteLine("");
            string scoreBoxer2_2_str = Validation.StringOptions("Round #2: Boxer2 score: 10 or 9?", options);

            int scoreBoxer2_2 = Convert.ToInt32(scoreBoxer2_2_str);
            Console.WriteLine("");

            //Console.WriteLine("Boxer1 score: " + scoreBoxer1_2 + "; Boxer2 score " + scoreBoxer2_1);
          //  string round2Result = DetermineWinnerRound_Overall.DisplayRoundWinner(scoreBoxer1_2, scoreBoxer2_2, 2, "M");
            //Console.WriteLine(round2Result);
            Console.WriteLine("");
            Console.ReadLine();
            string round1Display1 = scoreBoxer1_2_str;
            string round1Display2 = scoreBoxer2_2_str;

            return round1Display1;
        }

    }
}
