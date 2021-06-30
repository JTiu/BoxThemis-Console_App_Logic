using System;
using System.Collections.Generic;
using System.Text;

namespace Boxing_Logic
{
    public class RoundResult //new class, has two properties
    {
        public int Boxer1Score { get; set; }   //get/set is a property. not a variable in this instance.  the property is a wrapper around the variable. greater control over the variable
        public int Boxer2Score { get; set; }

        public string AnyCrazyThing { get; set; }

        private int myVar;

        public int BoxerThreeScore
        {
            get { return myVar; }
            set { 
                if(value < 0)
                {
                    throw new Exception("cannot use value less than zero");
                }
                
                
                
                myVar = value; }


        }

    }
}
