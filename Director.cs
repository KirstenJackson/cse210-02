using System;

namespace cse210_02
{
    public class Director
    {
        public static int calcScore(int score, int card1, int card2, string guess)
        {
            if (
                (guess == "l" && card1 > card2) ||
                (guess == "h" && card1 < card2))
            {
                score += 100;
            }
            else
            {
                score -= 75;
            }

            return score;
        }

        public static void playGame()
        {
            bool Playing = true;
            int score = 300;

            while (Playing == true)
            {
                int card1 = Card.drawCard();
                int card2 = Card.drawCard();

                Console.WriteLine($"The current card is: {card1}");
                string guess = Player.makeGuess();
                Console.WriteLine($"The next card is: {card2}");

                score = Director.calcScore(score, card1, card2, guess);
                Console.WriteLine($"Your score is: {score}");

                if (score <= 0)
                {
                    Playing = false;
                    Console.WriteLine("Game over.");
                }
                else
                {
                    string choice = Player.playAgain();
                    if (choice == "n")
                    {
                        Playing = false;
                        Console.WriteLine("Thank you.");
                    }
                    else
                    {
                        Playing = true;
                    }

                }


            }

        }

    }
}
