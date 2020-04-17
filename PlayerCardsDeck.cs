using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardGame
{
    public class PlayerCardsDeck
    {
        private readonly List<SingleCard> Cards = new List<SingleCard>();
        
        private readonly List<string> _listWithDataFromFile = new List<string>();
        
        
        public PlayerCardsDeck(int amountCards)
        {
            DrawCardsFromCardsDeck(Game.AmountCards);
        }

        
        public List<SingleCard> GetCards()
        {
            return Cards;
        }


        private void DrawCardsFromCardsDeck(int amountCards) //metoda losujący karty dla każdego gracza 
        {
            var cardsDeck = new CardsDeck();
            var allCardsDeck = cardsDeck.GetAllCardsDeck();
            Random random = new Random();
            int i = 0;
            while(i < amountCards)
            {
                string PlayerCards = allCardsDeck[random.Next(allCardsDeck.Count)];
                this._listWithDataFromFile.Add(allCardsDeck[random.Next(allCardsDeck.Count)]); //skorzystałem z listy 
                allCardsDeck.Remove(PlayerCards);
                i++;
             }
            AddSingleCardToCards();
        }
        
        
        private void AddSingleCardToCards() //metoda dodająca pojedyńczą kartę do słownika "Cards"
        {
            foreach (var VARIABLE in _listWithDataFromFile)
            {
                string[] elementsForAddToSingleCard = VARIABLE.Split(",");
                SingleCard newSingleCard = new SingleCard(
                    elementsForAddToSingleCard[0],
                    elementsForAddToSingleCard[1],
                    elementsForAddToSingleCard[3],
                    elementsForAddToSingleCard[4],
                    elementsForAddToSingleCard[2]);
                Cards.Add(newSingleCard);
            }
        }
    }
}