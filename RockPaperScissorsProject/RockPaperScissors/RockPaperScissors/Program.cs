using System;
using RockPaperScissors.Library;

namespace RockPaperScissors
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets Play Rock, Paper Scissors!");
            Game one = new Game();
            one.Play();
            Console.WriteLine(one.GameResults());
            Console.Write("What round do you want to get the result of? ");
            int round = int.Parse(Console.ReadLine());
            Console.WriteLine($"{one.GetRoundResult(round)} Round {round}");
        }
    }
}
