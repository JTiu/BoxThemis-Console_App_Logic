using System;

namespace Boxing_Logic
{
    class Program
    {
        static int tableWidth = 113;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Boxing Judging Tutorial.\n\nThis is a three round match.\n\nThe Boxer who wins the round gets '10', the Boxer who loses the round gets a '9'.\n \nAre you ready to begin?");
            Console.WriteLine("");
            //Round 1
            Console.WriteLine("Round #1: Boxer1 score: 10 or 9?");
            Console.WriteLine("");

            int scoreBoxer1_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Round#1: Boxer2 score: 10 or 9?");
            Console.WriteLine("");

            int scoreBoxer2_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Boxer1 score: " + scoreBoxer1_1 + "; Boxer2 score: " + scoreBoxer2_1 + "\n");
            Console.WriteLine("");

            {
                bool Boxer1Wins = true;
                if (scoreBoxer1_1 > scoreBoxer2_1)
                {
                    Console.WriteLine("Boxer1 won Round#1!");
                }
                else
                {
                    Console.WriteLine("Player2 won Round#1");
                }
            }
            Console.Clear();
            //Round 2
            Console.WriteLine("Round #2: Boxer1 score: 10 or 9?");
            Console.WriteLine("");

            int scoreBoxer1_2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Round#2: Boxer2 score: 10 or 9?");
            Console.WriteLine("");

            int scoreBoxer2_2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Boxer1 score: " + scoreBoxer1_2 + "; Boxer2 score " + scoreBoxer2_1);
            Console.WriteLine("");

            {
                bool Boxer1Wins = true;
                if (scoreBoxer1_2 > scoreBoxer2_2)
                {
                    Console.WriteLine("Boxer1 won Round#2!");
                }
                else
                {
                    Console.WriteLine("Player2 won Round#2");
                }
            }
            Console.Clear();
            //Round 3
            Console.WriteLine("Round #3: Boxer1 score: 10 or 9?");
            Console.WriteLine("");

            int scoreBoxer1_3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Round#2: Boxer2 score: 10 or 9?");
            Console.WriteLine("");

            int scoreBoxer2_3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Boxer1 score: " + scoreBoxer1_3 + "; Boxer2 score " + scoreBoxer2_3);
            Console.WriteLine("");

            {
                bool Boxer1Wins = true;
                if (scoreBoxer1_3 > scoreBoxer2_3)
                {
                    Console.WriteLine("Boxer1 won Round#3!");
                }
                else
                {
                    Console.WriteLine("Player2 won Round#3");
                }

            }
            Console.Clear();
            {
                Console.WriteLine("Let's determine the winner of the match:\n");
                int x = scoreBoxer1_1 + scoreBoxer1_2 + scoreBoxer1_3;
                int y = scoreBoxer2_1 + scoreBoxer2_2 + scoreBoxer2_3;
                bool Boxer1Wins = true;
                if (x> y)
                {
                    Console.WriteLine("Boxer1's score = " + x + "\n\nBoxer2's score = " + y + "\n\nBoxer1 wins!");
                }
                else
                {
                    Console.WriteLine("Boxer1's score = " + x + "\n\nBoxer2's score = " + y + "\n\nBoxer1 wins!");
                    Console.WriteLine("\n");
                }

            }
            {

                int x_1 = scoreBoxer1_1;
                int x_2 = scoreBoxer1_2;
                int x_3 = scoreBoxer1_3;
                int x_4 = scoreBoxer2_1;
                int x_5 = scoreBoxer2_2;
                int x_6 = scoreBoxer2_3;
                int x_7 = scoreBoxer1_1 + scoreBoxer1_2 + scoreBoxer1_3;
                int x_8 = scoreBoxer2_1 + scoreBoxer2_2 + scoreBoxer2_3;
                

                PrintLine();
                PrintRow("Round 1", "Round 2", "Round 3", "Total");
                PrintLine();
                PrintRow("" + x_1, "" + x_2, "" + x_3,  "" + x_7);
                PrintRow("" + x_4, "" +x_5, "" + x_6,  "" + x_8);
                PrintLine();
                Console.ReadLine();
            }

            static void PrintLine()
            {
                Console.WriteLine(new string('-', tableWidth));
            }

            static void PrintRow(params string[] columns)
            {
                int width = (tableWidth - columns.Length) / columns.Length;
                string row = "|";

                foreach (string column in columns)
                {
                    row += AlignCentre(column, width) + "|";
                }

                Console.WriteLine(row);
            }

            static string AlignCentre(string text, int width)
            {
                text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

                if (string.IsNullOrEmpty(text))
                {
                    return new string(' ', width);
                }
                else
                {
                    return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
                }
            }


        }
    }
}
