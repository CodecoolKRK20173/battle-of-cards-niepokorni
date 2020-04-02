using System.Collections.Generic;

namespace CardGame
{
    public class Game
    {
        
        public string NameOfTheGame { get; set; }

        public int NumberOfPlayers { get; set; }

        public static int AmountCards { get; set; }

        public List<Player> Players { get; } = new List<Player>();

        public PlayingTable PlayingTable { get; }
        
        public Game(string nameOfTheGame, int numberOfPlayers, int amountCardsForPlayers)
        {
            NameOfTheGame = nameOfTheGame;
            NumberOfPlayers = numberOfPlayers;
            AmountCards = amountCardsForPlayers;
            PlayingTable = new PlayingTable();
            //create new players
            for (var i = 0; i < numberOfPlayers; i++) Players.Add(new Player());
        }



    }
}