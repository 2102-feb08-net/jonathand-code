using System;
namespace RockPaperScissors.Library
{
    public class Player
    {
        private string move;
        public virtual string Move
        {
            get { return move; }
            set { move = value; }
        }
        public Player()
        {
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