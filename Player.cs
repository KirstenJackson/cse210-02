using System;

namespace cse210_02
{
    public class Player
    {
        public static string makeGuess()
        {
            Console.Write("Is the next card higher or lower? [h/l] ");
            string guess = Console.ReadLine();

            return guess;
        }

        public static string playAgain()
        {
            Console.Write("Would you like to play again? [y/n] ");
            string decision = Console.ReadLine();

            return decision;
        }


    }
}
