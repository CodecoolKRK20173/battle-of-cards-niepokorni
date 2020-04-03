using System;
using System.Linq;

namespace CardGame
{
    public class Player
    {
        public string Name { get; set; }
        public SingleCard SingleCardOnPlayerHand { get; private set; }
        public PlayerCardsDeck PlayerCardsDeck { get; }
        public bool WiningPlayer { get; set; } // zobaczymy
        
        
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
        }


        // metoda do doszlifowania
        public string ChoseValuFromSingleCardOnPlayerHand(int numberValueOnTheCard)
        {
            switch (numberValueOnTheCard)
            {
                case 1:
                    return SingleCardOnPlayerHand.EngineCapacity;
                case 2:
                    return SingleCardOnPlayerHand.Acceleration;
                case 3:
                    return SingleCardOnPlayerHand.EnginePower;
                case 4:
                    return SingleCardOnPlayerHand.MaxSpeed;
                default:
                    Console.WriteLine("Wrong Number");
                    break;
            }
            return "Wrong number";
        }
    }
}