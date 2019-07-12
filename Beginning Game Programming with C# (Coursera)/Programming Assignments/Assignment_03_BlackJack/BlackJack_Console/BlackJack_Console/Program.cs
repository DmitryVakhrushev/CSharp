using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ConsoleCards;

namespace BlackJack_Console
{
    /// <summary>
    /// console application that plays Blackjack
    /// </summary>
    class Program
    {
        /// <summary>
        /// console application that plays Blackjack
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            // set up console environment
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "Welcome to our Casino!!!";

            //Declare variables for and create a deck of cards and blackjack hands for the dealer and the player 
            Deck deck = new Deck();
            BlackjackHand dealerHand = new BlackjackHand("Dealer");
            BlackjackHand playerHand = new BlackjackHand("Player");

            //Print a “welcome” message to the user
            Console.WriteLine("This program will play a single hand of Blackjack");
            Console.WriteLine("");

            //Shuffle the deck of cards
            deck.Shuffle();
            //deck.Print();

            //Deal 2 cards to the player and dealer
            playerHand.AddCard(deck.TakeTopCard());
            playerHand.AddCard(deck.TakeTopCard());

            dealerHand.AddCard(deck.TakeTopCard());
            dealerHand.AddCard(deck.TakeTopCard());

            //Make all the player’s cards face up (you need to see what you have!); there's a method for this in the BlackjackHand class
            playerHand.ShowAllCards();

            //Make the dealer’s first card face up (the second card is the dealer’s “hole” card); there's a method for this in the BlackjackHand class 
            dealerHand.ShowFirstCard();

            //Print both the player’s hand and the dealer’s hand 
            playerHand.Print();
            dealerHand.Print();

            //Let the player hit if they want to
            Console.Write("Hit? (yes/no) ");
            char hit = Console.ReadLine()[0];
            switch (hit)
            {
                case 'y':
                case 'Y':
                    playerHand.AddCard(deck.TakeTopCard());
                    playerHand.ShowAllCards();
                    break;
            }

            //Make all the dealer’s cards face up; there's a method for this in the BlackjackHand class 
            dealerHand.ShowAllCards();

            //Print both the player’s hand and the dealer’s hand 
            playerHand.Print();
            dealerHand.Print();

            //Print the scores for both hands 
            Console.WriteLine("Player's score = " + playerHand.Score);
            Console.WriteLine("Dealer's score = " + dealerHand.Score);
        }
    }
}
