using System.Collections.Generic;

namespace CardGame
{
    public class PlayerCardsDeck
    {
        private int AmountCards;
        
        private Dictionary<string, SingleCard> Cards = new Dictionary<string, SingleCard>();
        


        public PlayerCardsDeck(int amountCards)
        {
            this.AmountCards = amountCards;
            DrawCardsFromCardsDeck(AmountCards);
        }
        
        
        public Dictionary<string, SingleCard> GetCards()
        {
            return Cards;
        }

        
        private void DrawCardsFromCardsDeck(int AmountCards) //metoda losujący karty dla każdego gracza 
        {
            var cardsDeck = new CardsDeck();
            var allCardsDeck = cardsDeck.GetAllCardsDeck();
            //Radek  - zaimplementuj proszę swoją  metodę, która losuje określoną ilość kart "amountCards" z "CardsDeck"
            //i wypełnij słownik pojedyńczeg gracza - czyli słownik "Cards"
            
            Cards.Add("Opel", new SingleCard("Opel", 200, 23123, 321, 2121));
            Cards.Add("Opel1", new SingleCard("Opel11", 200, 23123, 321, 2121));
            Cards.Add("Opel2", new SingleCard("Opel22", 200, 23123, 321, 2121));
            Cards.Add("Opel3", new SingleCard("Opel33", 200, 23123, 321, 2121));

            
        }

        
        private void AddSingleCardToCards(SingleCard card) //metoda dodająca pojedyńczą kartę do słownika "Cards"
        {
            // ...
        }

        

    }
}