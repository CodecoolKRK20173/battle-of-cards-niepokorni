using System.Collections.Generic;

namespace CardGame
{
    public class Game
    {
        private string nameOfTheGame;
        private int numberOfPlayers;
        private static int amountCards;
        private PlayingTable _playingTable;
        private Dictionary<string, Player> players = new Dictionary<string, Player>();
        
        
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

        public PlayingTable PlayingTable => _playingTable;
        

        public Game(string nameOfTheGame, int numberOfPlayers, int amountCardsForPlayers)
        {
            NameOfTheGame = nameOfTheGame;
            NumberOfPlayers = numberOfPlayers;
            AmountCards = amountCardsForPlayers;
            this._playingTable = new PlayingTable();
            //create new players
            for (int i = 1; i <= numberOfPlayers; i++)
            {
                players[$"Player nr {i}"] = new Player();
            }
            
        }
        
        
    }
    
}