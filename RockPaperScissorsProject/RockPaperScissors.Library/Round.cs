using System;

namespace RockPaperScissors.Library
{
    public class Round
    {
        private Player me;
        private ComputerPlayer com;
        private string result;

        public string Result
        {
            get { return result; }
            set { result = value; }
        }

        public Round()
        {
            me = new Player();
            com = new ComputerPlayer();
        }

        public void PlayRound()
        {
            Console.WriteLine("What is your move? Rock, Paper or Scissors?");
            me.Move = Console.ReadLine();
            while (!me.IsValidAnswer(me.Move))
            {
                Console.WriteLine("What is your move?");
                me.Move = Console.ReadLine();
            }
            Console.WriteLine($"Your move was {me.Move}");
            com.GenerateMove();
            Console.WriteLine($"The computers move was {com.Move}");
            CheckWinner();
        }

        public void CheckWinner()
        {
            if (IsTie())
            {
                Result = "You tied";
                Console.WriteLine("Its a tie");
                //Console.WriteLine($"User has {Player.Wins} wins and {ComputerPlayer.Wins} loses");
            }
            if (IsPlayerWin())
            {
                Result = "You won";
                //Player.Wins++;
                Console.WriteLine("You Win!");
                //Console.WriteLine($"User has {Player.Wins} wins and {ComputerPlayer.Wins} loses");
            }
            if (IsComputerWin())
            {
                Result = "The Computer won";
                //ComputerPlayer.Wins++;
                Console.WriteLine("Computer Wins :(");
                //Console.WriteLine($"Computer has {ComputerPlayer.Wins} wins and {Player.Wins} loses");
            }
        }
        
        public bool IsTie()
        {
            return (me.Move.ToUpper() == com.Move.ToUpper());
        }

        public bool IsPlayerWin()
        {
            return (me.Move.ToUpper() == "ROCK" && com.Move.ToUpper() == "SCISSORS") || (me.Move.ToUpper() == "PAPER" && com.Move.ToUpper() == "ROCK")
             || (me.Move.ToUpper() == "SCISSORS" && com.Move.ToUpper() == "PAPER");
        }

        public bool IsComputerWin()
        {
            return ((me.Move.ToUpper() == "SCISSORS" && com.Move.ToUpper() == "ROCK") ||
            (me.Move.ToUpper() == "ROCK" && com.Move.ToUpper() == "PAPER") || (me.Move.ToUpper() == "PAPER" && com.Move.ToUpper() == "SCISSORS"));
        }
    }
}

