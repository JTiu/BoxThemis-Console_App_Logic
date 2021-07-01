using System;
using System.Collections.Generic;
using System.Text;

namespace Boxing_Logic
{
    public static class RoundOne
    {
        public static RoundResult R1Method(BoxerName_Weight anyParamerNameIchoose) //this method will return a instance from the RoundResult class, need to change Round two and three
        {

            RoundResult roundResult = new RoundResult(); //this is the instance.  I initialize this instance
            
            List<string> options = new List<string>();
            options.Add("7");
            options.Add("8");
            options.Add("9");
            options.Add("10");


            
           

            string scoreBoxer1_1_str = Validation.StringOptions($"Round #1: {anyParamerNameIchoose.NameBoxer1}'s score: 10 or 9?", options);//#here
            string scoreBoxer2_1_str = Validation.StringOptions($"Round #1: {anyParamerNameIchoose.NameBoxer2}'s score: 10 or 9?", options);
            int scoreBoxer1_1 = Convert.ToInt32(scoreBoxer1_1_str);

            
            string anotherStatement = Validation.StringOptions($"Record: {anyParamerNameIchoose.RecordBoxer1}'s KO's:", options);//#here

            int scoreBoxer2_1 = Convert.ToInt32(scoreBoxer2_1_str);
            Console.WriteLine("");

            Console.WriteLine("Boxer1 score: " + scoreBoxer1_1 + "; Boxer2 score: " + scoreBoxer2_1 + "\n" + anotherStatement);
            Console.WriteLine("");
            string round1Result = DetermineWinnerRound_Overall.DisplayRoundWinner(scoreBoxer1_1, scoreBoxer2_1, 1);
            Console.WriteLine(round1Result);
            Console.ReadLine();
            

            roundResult.Boxer1Score = scoreBoxer1_1;
            roundResult.Boxer2Score = scoreBoxer2_1;
           

            return roundResult;
            
        }
        


    }
}
