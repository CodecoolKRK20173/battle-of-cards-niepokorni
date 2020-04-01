using System.Collections.Generic;

namespace CardGame
{
    public class PlayerCardsDeck
    {
        private int AmountCards;
        
        private Dictionary<string, SingleCardGame> Cards;


        public PlayerCardsDeck(int amountCards)
        {
            this.AmountCards = amountCards;
            DrawCardsFromCardsDeck(AmountCards);
        }
        
        
        public Dictionary<string, SingleCardGame> GetCards()
        {
            return Cards;
        }

        
        private void DrawCardsFromCardsDeck(int AmountCards) //metoda losujący karty dla każdego gracza 
        {
            var cardsDeck = new CardsDeck();
            var allCardsDeck = cardsDeck.GetAllCardsDeck();
            //Radek  - zaimplementuj proszę swoją  metodę, która losuje określoną ilość kart "amountCards" z "CardsDeck"
            //i wypełnij słownik pojedyńczeg gracza - czyli słownik "Cards"
        }

        
        private void AddSingleCardToCards(SingleCardGame card) //metoda dodająca pojedyńczą kartę do słownika "Cards"
        {
            // ...
        }

        

    }
}