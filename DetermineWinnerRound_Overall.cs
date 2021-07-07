using System;
using System.Collections.Generic;
using System.Text;

namespace Boxing_Logic
{
    public class DetermineWinnerRound_Overall 
    {
        
       
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
