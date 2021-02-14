using System;

namespace RockPaperScissors
{
    public class ComputerPlayer : Player
    {
        //private static int wins;
        //public static int Wins
        //{
        //    get { return wins; }
        //    set { wins = value; }
        //}

        public ComputerPlayer()
        {
            //Wins = 0;
        }

        public void GenerateMove()
        {
            Random gen = new Random();
            int moveNum = gen.Next(3);
            if (moveNum == 0)
            {
                Move = "Rock";
            }
            else if (moveNum == 1)
            {
                Move = "Paper";
            }
            else
            {
                Move = "Scissors";
            }
        }
    }
}

