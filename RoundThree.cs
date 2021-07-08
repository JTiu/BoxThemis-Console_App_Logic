using System;
using System.Collections.Generic;
using System.Text;

namespace Boxing_Logic
{
    public class RoundThree
    {
        public static RoundResult R3Method(BoxerName_Weight_Record anyParamerNameIchoose) //this method will return a instance from the RoundResult class, need to change Round two and three
        {

            RoundResult roundResult = new RoundResult(); //this is the instance.  I initialize this instance

            List<string> options = new List<string>();
            options.Add("0");
            options.Add("1");
            options.Add("2");
            options.Add("3");
            options.Add("4");
            options.Add("5");
            options.Add("6");
            options.Add("7");
            options.Add("8");
            options.Add("9");
            options.Add("10");

            string scoreBoxer1_1_str = Validation.StringOptions($"Round #3: {anyParamerNameIchoose.NameBoxer1}'s score: 10 or 9?", options);
            string scoreBoxer2_1_str = Validation.StringOptions($"Round #3: {anyParamerNameIchoose.NameBoxer2}'s score: 10 or 9?", options);
            string deductionsBoxer1_1_str = Validation.StringOptions($"Round #3: {anyParamerNameIchoose.NameBoxer1}'s deductions?", options);
            string deductionsBoxer2_1_str = Validation.StringOptions($"Round #3: {anyParamerNameIchoose.NameBoxer2}'s deductions?", options);

            int scoreBoxer1_1 = Convert.ToInt32(scoreBoxer1_1_str);
            int scoreBoxer2_1 = Convert.ToInt32(scoreBoxer2_1_str);
            Console.WriteLine("");

            Console.WriteLine($"{anyParamerNameIchoose.NameBoxer1}'s score: " + scoreBoxer1_1 + $"\n{anyParamerNameIchoose.NameBoxer2}'s score: " + scoreBoxer2_1);
            Console.WriteLine($"Deductions: {anyParamerNameIchoose.NameBoxer1}: {deductionsBoxer1_1_str}, {anyParamerNameIchoose.NameBoxer2}: {deductionsBoxer2_1_str}");
            Console.WriteLine("");

          
            roundResult.Boxer1Score = scoreBoxer1_1;
            roundResult.Boxer2Score = scoreBoxer2_1;

            if (scoreBoxer1_1 > scoreBoxer2_1)
            {
                Console.WriteLine($"{anyParamerNameIchoose.NameBoxer1} wins round 3\n");
            }
            else if (scoreBoxer1_1 < scoreBoxer2_1)
            {
                Console.WriteLine($"{anyParamerNameIchoose.NameBoxer2} wins round 3\n");
            }
            else
            {
                Console.WriteLine("Tied round 3n");
            }

            return roundResult;

        }

    }
}
