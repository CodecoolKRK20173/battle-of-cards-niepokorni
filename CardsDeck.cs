using System.Collections.Generic;

namespace CardGame
{
    public class CardsDeck
    {
        private List<string> AllCardsDeck;
        private readonly int amountCards = 1000;

        public CardsDeck() //konstruktor CardsDeck, który tworzy obiekt z wypełnioną talią kart
        {
            AddCardsFromFile(amountCards);
        }


        private void AddCardsFromFile(int amountCards) //metoda wypełniająca listę AllCardsDeck elmentami z bazy danych
        {
            //....
        }


        public List<string> GetAllCardsDeck() //metoda publiczna, za pomocą której możemy pobrać gotową listę
        {
            return AllCardsDeck;
        }
    }
}