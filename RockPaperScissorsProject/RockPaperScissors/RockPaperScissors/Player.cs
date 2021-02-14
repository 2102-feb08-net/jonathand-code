using System;
namespace RockPaperScissors
{
    public class Player
    {
        private string move;
        //private static int wins;
        public string Move
        {
            get { return move; }
            set { move = value; }
        }
        //public static int Wins
        //{
        //    get { return wins; }
        //    set { wins = value; }
        //}
        public Player()
        {
            //Wins = 0;
        }

        public bool IsValidAnswer(string m)
        {
            if (m.ToUpper() == "ROCK" || m.ToUpper() == "SCISSORS" || m.ToUpper() == "PAPER")
            {
                return true;
            }
            else
            {
                Console.WriteLine("That is not a valid answer.");
                return false;
            }
        }

    }
}