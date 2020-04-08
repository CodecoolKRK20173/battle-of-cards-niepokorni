using System.Collections.Generic;
using System.IO;

namespace CardGame
{
    public class CardsDeck
    {
        private List<string> allCardsDeck = new List<string>();

        public CardsDeck()
        {
            AddCardsFromFile();
        }
        
        
        public List<string> GetAllCardsDeck()
        {
            return allCardsDeck;
        }
        
        
        private void AddCardsFromFile()
        {
            string path = "cars.csv";
            string file = File.ReadAllText(path);
            string[] linesInFile = file.Split("\n");
            for (int i = 0; i < linesInFile.Length; i++)
            {
                allCardsDeck.Add(linesInFile[i]);
            }
        }
    }
}