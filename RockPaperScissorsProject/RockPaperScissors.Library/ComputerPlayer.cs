using System;

namespace RockPaperScissors.Library
{
    public class ComputerPlayer : Player
    {
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

