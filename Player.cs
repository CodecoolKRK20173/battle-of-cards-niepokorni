using System;
using System.Collections.Generic;
using System.Linq;

namespace CardGame
{
    public class Player
    {
        public string Name { get; set; }
        public SingleCard SingleCardOnPlayerHand { get; private set; }
        public PlayerCardsDeck PlayerCardsDeck { get; }
        public List<SingleCard> PlayerWinningCardsDeck = new List<SingleCard>();
        public bool StatusOfWinning { get; set; }
        
        
        public Player()
        {
            PlayerCardsDeck = new PlayerCardsDeck(Game.AmountCards);
            DrawSingleCardOnPlayerHand();
        }
        
        
        public void DrawSingleCardOnPlayerHand()
        {
            var random = new Random();
            var index = random.Next(PlayerCardsDeck.GetCards().Count);
            var randomSingleCard = PlayerCardsDeck.GetCards()[index];
            SingleCardOnPlayerHand = randomSingleCard; 
            PlayerCardsDeck.GetCards().Remove(randomSingleCard);//remove card after drawing
        }
        
    }
}