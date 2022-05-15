using System;


namespace cse210_02
{
    public class Card
    {
        public static int drawCard()
        {
            Random card = new Random();
            int value = card.Next(1, 14);

            return value;
        }
    }
}
