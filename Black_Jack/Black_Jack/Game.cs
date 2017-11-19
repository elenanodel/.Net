using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack
{
    public class Game
    {
        Random rand = new Random();
        Card[] cards = new Card[36];
        int computerPoints;
        int userPoints;

        public void Deck()
        {
            cards = new Card[36];
            int count = 0;

            foreach (Suit suits in Enum.GetValues(typeof(Suit)))
            {
                foreach (Value cardValue in Enum.GetValues(typeof(Value)))
                {
                    cards[count] = new Card() { CardSuit = suits, CardValue = cardValue };
                    count++;
                }
            }
        }
        public void WhoRecievesFirstCard()
        {
            bool choice = false;
            while (!choice)
            {
                int c = rand.Next(0, 36);
                Card computer = cards[c];
                int u = rand.Next(0, 36);
                Card user = cards[u];

                if (user.CardValue > computer.CardValue)
                {
                    Console.WriteLine("Computer starts first!");
                    ComputerPlays();
                    choice = true;
                }

                if (user.CardValue < computer.CardValue)
                {
                    Console.WriteLine("User starts first!");
                    UserPlays();
                    choice = true;
                }

                if (user.CardValue == computer.CardValue)
                {
                    Console.WriteLine("Try again!");
                }

            }
        }
        public int FirstRecieve()
        {
            for (int i = 0; i < 2; i++)
            {
                int card = rand.Next(0, 36);
                if (!cards[card].used)
                {
                    computerPoints += (int)cards[card].CardValue;
                    Console.WriteLine($"{cards[card].CardValue} - {cards[card].CardSuit} ");
                    cards[card].used = true;
                    i++;
                }
            }
            return computerPoints;
        }
        public void ComputerPlays()
        {
            bool b = false;
            computerPoints = FirstRecieve();

            if (computerPoints == 22)
            {
                Console.WriteLine("Computer win!");
                if (userPoints == 0)
                {
                    Console.WriteLine("User plays...");
                    UserPlays();
                    b = true;
                }
                else
                {
                    Winner();
                    b = true;
                }
            }
           
            while (!b)
            {
                if (computerPoints <= 18)
                {
                    int card = rand.Next(0, 36);

                    if (!cards[card].used)
                    {
                        computerPoints += (int)cards[card].CardValue;
                        Console.WriteLine($"{cards[card].CardValue} - {cards[card].CardSuit} ");
                        cards[card].used = true;                        
                    }
                }
                
                if(computerPoints > 18)
                {
                    Console.WriteLine("Computer doesn't want to take another card");
                    b = true;
                }
            }

            if (userPoints == 0)
            {
                Console.WriteLine("User plays...");
                UserPlays();
            }
            else
            {
                Winner();
            }
        }
        public void UserPlays()
        {
            bool b = false;
            userPoints = FirstRecieve();

            if(userPoints == 22)
            {
                Console.WriteLine("User win!");
                if(computerPoints == 0)
                {
                    Console.WriteLine("Computer plays...");
                    ComputerPlays();
                    b = true;
                }
                else
                {
                    Winner();
                    b = true;
                }
            }

            while (!b)
            {                
                Console.WriteLine("Do you want to recieve another card?");
                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");
                Console.WriteLine("Please, enter your choice: ");
                char choice = char.Parse(Console.ReadLine());

                switch (choice)
                {
                    case '1':
                        {
                            int card = rand.Next(0, 36);

                            if (!cards[card].used)
                            {
                                userPoints += (int)cards[card].CardValue;
                                Console.WriteLine($"{cards[card].CardValue} - {cards[card].CardSuit} ");
                                cards[card].used = true;
                            }
                            break;
                        }
                    case '2':
                        {                            
                            Winner();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Please, try again! You should enter 1 or 2.");
                            break;
                        }                      
                }
            }

            if (computerPoints == 0)
            {
                Console.WriteLine( "Computer plays...");
                ComputerPlays();
            }
            else
            {
                Winner();
            }

        }
        public void Winner()
        {
            if (computerPoints > userPoints)
            {
                Console.WriteLine("Computer win!");
                Console.WriteLine("Computer points: " + computerPoints);
                Console.WriteLine("Your points: " + userPoints);
            }
            if (computerPoints < userPoints)
            {
                Console.WriteLine("You win!");
                Console.WriteLine("Your points: " + userPoints);
                Console.WriteLine("Computer points: " + computerPoints);               
            }
            if (computerPoints == userPoints)
            {
                Console.WriteLine("Dead heat!");
                Console.WriteLine("You and computer have {0} points", userPoints);
            }
        }
    }
}
