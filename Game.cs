using System.Collections.Generic;

namespace CardGame
{
    public class Game
    {
        private string nameOfTheGame;
        private int numberOfPlayers;
        private static int amountCards;
        private PlayingTable _playingTable;
        private List<Player> players = new List<Player>();
        
        
        public string NameOfTheGame
        {
            get => nameOfTheGame;
            set => nameOfTheGame = value;
        }

        public int NumberOfPlayers
        {
            get => numberOfPlayers;
            set => numberOfPlayers = value;
        }

        public static int AmountCards
        {
            get => amountCards;
            set => amountCards = value;
        }

        public List<Player> Players => players;

        public PlayingTable PlayingTable => _playingTable;
        

        public Game(string nameOfTheGame, int numberOfPlayers, int amountCardsForPlayers)
        {
            NameOfTheGame = nameOfTheGame;
            NumberOfPlayers = numberOfPlayers;
            AmountCards = amountCardsForPlayers;
            this._playingTable = new PlayingTable();
            //create new players
            for (int i = 0; i < numberOfPlayers; i++)
            {
                 players.Add(new Player());
            }
            
        }
        
        
    }
    
}