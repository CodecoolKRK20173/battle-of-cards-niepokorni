using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardGame
{
    public class PlayerCardsDeck
    {
        private readonly int AmountCards;

        private readonly Dictionary<string, SingleCard> Cards = new Dictionary<string, SingleCard>();


        public PlayerCardsDeck(int amountCards)
        {
            AmountCards = amountCards;
            DrawCardsFromCardsDeck(AmountCards);
        }

        public Dictionary<string, SingleCard> GetCards()
        {
            return Cards;
        }


        private string DrawCardsFromCardsDeck(int AmountCards) //metoda losujący karty dla każdego gracza 
        {
            string PlayerCards = "";
            var cardsDeck = new CardsDeck();
            var allCardsDeck = cardsDeck.GetAllCardsDeck();

            Random losuj = new Random();
            int i = 0;
            while(i < AmountCards)
            {
                PlayerCards = allCardsDeck[losuj.Next(allCardsDeck.Count)];
                allCardsDeck.Remove(PlayerCards);
                System.Console.WriteLine(PlayerCards);
                i++;

            }
            return PlayerCards;
        }
        
        private void AddSingleCardToCards(SingleCard card) //metoda dodająca pojedyńczą kartę do słownika "Cards"
        {
            
        }
    }
}