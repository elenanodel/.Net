using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_22_26
{
    public enum Suit
    {
        DIAMONDS, CLUBS, HEARTS, SPADES
    };

    public enum Value
    {
        JACK = 2, LADY = 3, KING = 4, SIX = 6, SEVEN = 7, EIGHT = 8, NINE = 9, TEN = 10,  ACE = 11
    };

    struct Card
    {
        public Suit suit;
        public Value value;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Card cards = new Card();

            
            
        }
    }
}
