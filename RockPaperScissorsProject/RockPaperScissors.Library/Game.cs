using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors.Library
{
    public class Game
    {
        private List<Round> results;
        //private Round g = new Round();
        private int PlayerWins;
        private int ComWins;

        public Game()
        {
            results = new List<Round>();
        }

        public void Play()
        {
            while(KeepPlaying())
            {
                var g = new Round();
                g.PlayRound();
                results.Add(g);
                if(g.IsPlayerWin())
                {
                    PlayerWins++;
                }
                if(g.IsComputerWin())
                {
                    ComWins++;
                }
            }
        }

        public string GameResults()
        {
            string totalResults = "Round Results\n";
            for(int i = 0; i < results.Count; i++)
            {
                if(i == results.Count - 1)
                {
                    totalResults += results[i].Result + " Round " + (i + 1);
                }
                else
                {
                    totalResults += results[i].Result + " Round " + (i + 1) + "\n";
                }
            }

            return totalResults;
        }
        public bool KeepPlaying()
        {
            Console.WriteLine("Do you want to play? y or n");
            string choice = Console.ReadLine().ToUpper();
            if (choice.ToUpper() == "Y")
            {
                return true;
            }
            else if (choice.ToUpper() == "N")
            {
                if (PlayerWins > ComWins)
                {
                    Console.WriteLine($"User has {PlayerWins} wins and {ComWins} loses");
                    Console.WriteLine("You have more wins, you won the game!");
                }
                else if(PlayerWins < ComWins)
                {
                    Console.WriteLine($"User has {PlayerWins} wins and {ComWins} loses");
                    Console.WriteLine("Computer has more wins, you lost the game :(");
                }
                else
                {
                    Console.WriteLine($"User has {PlayerWins} wins and {ComWins} loses");
                    Console.WriteLine("You tied the game.");
                }
                return false;
            }
            else
                {
                    Console.WriteLine("Not a move");
                    KeepPlaying();
                }
            return false;
        }

        public string GetRoundResult(int round)
        {
            return results[round-1].Result;
        }
    }
}
