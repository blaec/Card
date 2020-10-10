using System;
using System.Collections.Generic;

namespace Card
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<Card> cards = new List<Card>();

            for (int i = 0; i < 15; i++)
            {
                Card card = new Card((Suits)random.Next(4), (Values)random.Next(1, 14));
                cards.Add(card);
            }

            foreach (Card card in cards)
            {
                Console.WriteLine($"{Card.DoesCardMatch(card, Suits.Clubs)} | {card}");
            }
            Console.WriteLine("------------- sorting... ---------------");
            CardComparer_byValue comparer = new CardComparer_byValue();
            cards.Sort(comparer);
            foreach (Card card in cards)
            {
                Console.WriteLine(card);
            }

        }
    }
}
