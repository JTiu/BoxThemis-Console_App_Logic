using System;
using System.Collections.Generic;
using System.Text;

namespace Boxing_Logic
{
    public static class DetermineWinnerRound_Overall
    {

        public static string DisplayRoundWinner(int boxer1Score, int boxer2Score, int round)
        {
            if(boxer1Score > boxer2Score)
            {
                return $"Boxer 1 wins round {round}";
            }
            else if(boxer1Score < boxer2Score)
            {
                return $"Boxer 2 wins round {round}";
            }
            else
            {
                return $"Tied round: {round}";
            }
        }
        public static string DisplayOverallWinner(int aggregateboxer1Score, int aggregateboxer2Score)
        {
            Console.WriteLine("Overall Winner of this match:");
            if (aggregateboxer1Score > aggregateboxer2Score)
            {
                return "Boxer 1 wins match";
               
            }
            else if (aggregateboxer1Score < aggregateboxer2Score)
            {
                return "Boxer 2 wins match";
                
            }
            else if (aggregateboxer1Score == aggregateboxer2Score)
            {
                return "Draw";
            }
            else
            {
                return "Play Again";
            }
        }
    }
}
