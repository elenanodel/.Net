using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack
{
    enum Suit { CLUBS, DIAMONDS, HEARTS, SPADES }
    enum Value { SIX = 6, SEVEN = 7, EIGHT = 8, NINE = 9, TEN = 10, JACK = 2, QUEEN = 3, KING = 4, ACE = 11 }

    struct Card
    {
        public Suit CardSuit;
        public Value CardValue;
        public bool used;
    }

     class Program
     {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Black Jack game!");
            Game game = new Game();
            game.Deck();
            game.WhoRecievesFirstCard();
            game.FirstRecieve();
            game.ComputerPlays();
            game.UserPlays();
            game.Winner();
        }
     }
 }
