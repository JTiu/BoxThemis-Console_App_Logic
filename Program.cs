using System;

namespace Boxing_Logic
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Greeting.Instruction1();
            Greeting.Instruction2();

            BoxerName_Weight_Record askBoxerName_WeightRecord = new BoxerName_Weight_Record();
            askBoxerName_WeightRecord.NameBoxer1 = Validation.String("What is boxer one's name?");
            askBoxerName_WeightRecord.NameBoxer2 = Validation.String("What is boxer two's name?");
            askBoxerName_WeightRecord.WeightBoxer1 = Validation.String($"What is {askBoxerName_WeightRecord.NameBoxer1}'s weight?");
            askBoxerName_WeightRecord.WeightBoxer2 = Validation.String($"What is {askBoxerName_WeightRecord.NameBoxer2}'s weight?");
            askBoxerName_WeightRecord.WinsBoxer1 = Validation.String($"How many wins on {askBoxerName_WeightRecord.NameBoxer1}'s record? {askBoxerName_WeightRecord.WinsBoxer1}");
            askBoxerName_WeightRecord.WinsBoxer2 = Validation.String($"How many wins on {askBoxerName_WeightRecord.NameBoxer2}'s record? {askBoxerName_WeightRecord.WinsBoxer2}");
            askBoxerName_WeightRecord.LossesBoxer1 = Validation.String($"How many losses on {askBoxerName_WeightRecord.NameBoxer1}'s record? {askBoxerName_WeightRecord.LossesBoxer1}");
            askBoxerName_WeightRecord.LossesBoxer2 = Validation.String($"How many losses on {askBoxerName_WeightRecord.NameBoxer2}'s record? {askBoxerName_WeightRecord.LossesBoxer2}");
            askBoxerName_WeightRecord.KOBoxer1 = Validation.String($"How many KO's on {askBoxerName_WeightRecord.NameBoxer1}'s record? {askBoxerName_WeightRecord.KOBoxer1}");
            askBoxerName_WeightRecord.KOBoxer2 = Validation.String($"How many KO's on {askBoxerName_WeightRecord.NameBoxer2}'s record? {askBoxerName_WeightRecord.KOBoxer2}");

            PrintTable.PrintLine();
            PrintTable.PrintRow("BoxerName", "Boxer Weight", "Wins", "Losses", "KO's");
            PrintTable.PrintLine();
            PrintTable.PrintRow(askBoxerName_WeightRecord.NameBoxer1, askBoxerName_WeightRecord.WeightBoxer1, askBoxerName_WeightRecord.WinsBoxer1, askBoxerName_WeightRecord.WinsBoxer1, askBoxerName_WeightRecord.WinsBoxer1);
            PrintTable.PrintLine();
            PrintTable.PrintRow(askBoxerName_WeightRecord.NameBoxer2, askBoxerName_WeightRecord.WeightBoxer2, askBoxerName_WeightRecord.WinsBoxer2, askBoxerName_WeightRecord.LossesBoxer2, askBoxerName_WeightRecord.KOBoxer2);
            PrintTable.PrintLine();

            RoundResult round1Result = RoundOne.R1Method(askBoxerName_WeightRecord); //need to replicate for rounds two and three
            Console.ReadLine();
            Console.Clear();
            RoundResult round2Result = RoundTwo.R2Method(askBoxerName_WeightRecord); //need to replicate for rounds two and three
            Console.ReadLine();
            Console.Clear();
            RoundResult round3Result = RoundThree.R3Method(askBoxerName_WeightRecord); //need to replicate for rounds two and three
            Console.ReadLine();
            Console.Clear();
            //string x1 = round1Result.ToString();

            string B1R1 = round1Result.Boxer1Score.ToString();
            string B1R2 = round2Result.Boxer1Score.ToString();
            string B1R3 = round3Result.Boxer1Score.ToString();
            string B2R1 = round1Result.Boxer2Score.ToString();
            string B2R2 = round2Result.Boxer2Score.ToString();
            string B2R3 = round3Result.Boxer2Score.ToString();
            int B1Total = round1Result.Boxer1Score + round2Result.Boxer1Score + round3Result.Boxer1Score;
            string B1TotalString = B1Total.ToString();
            int B2Total = round1Result.Boxer2Score + round2Result.Boxer2Score + round3Result.Boxer2Score;
            string B2TotalString = B2Total.ToString();
            PrintTable.PrintLine();
            PrintTable.PrintRow("", "Round 1", "Round 2", "Round Three", "Total");
            PrintTable.PrintLine();
            PrintTable.PrintRow(askBoxerName_WeightRecord.NameBoxer1, B1R1, B1R2, B1R3, B1TotalString);
            PrintTable.PrintLine();
            PrintTable.PrintRow(askBoxerName_WeightRecord.NameBoxer2, B2R1, B2R2, B2R3, B2TotalString);
            PrintTable.PrintLine();
            {


                //PrintTable.PrintRow("" + x_4, "" + x_5, "" + x_6, "" + x_8);
                PrintTable.PrintLine();
                Console.ReadLine();

            }
        }
    }
}
