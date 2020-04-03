using System.Collections.Generic;
using System.IO;

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
            string path = "cars.csv";
            string file = File.ReadAllText(path);
            string[] linesInFile = file.Split("\n");
            for (int i = 0; i < linesInFile.Length; i++)
            {
                AllCardsDeck.Add(linesInFile[i]);
            }
        }


        public List<string> GetAllCardsDeck() //metoda publiczna, za pomocą której możemy pobrać gotową listę
        {
            return AllCardsDeck;
        }
    }
}