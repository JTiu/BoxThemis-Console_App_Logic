using System;
using System.Collections.Generic;
using System.Text;

namespace Boxing_Logic
{
    public class RoundResult //new class, has 4 properties
    {
        public int Boxer1Score { get; set; }   //get/set is a property. not a variable in this instance.  the property is a wrapper around the variable. greater control over the variable
        public int Boxer2Score { get; set; }
        public int Boxer1KnockDownOrDeduction { get; set; }
        public int Boxer2KnockDownOrDeduction { get; set; }

        public int Winner { get; set; }
        public int Loser { get; set; }

        public string Hello  { get; set; }



    }
}
