using System;
using System.Collections.Generic;
using System.Text;

namespace Boxing_Logic
{
    public class BoxerName_Weight
    {
        public string NameBoxer1{ get; set; }
        public string NameBoxer2 { get; set; }
        public string WeightBoxer1 { get; set; }
        public string WeightBoxer2 { get; set; }

        public static string DisplayName()
        {
            
            return $"X's Name Displays";
        }
    }
}
