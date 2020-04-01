using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;

namespace CardGame
{
    public class Player

    {
    private string name;
    private PlayerCardsDeck playerCardsDeck;
    private SingleCard singleCardOnPlayerHand;

    public string Name
    {
        get => name;
        set => name = value;
    }

    public SingleCard SingleCardOnPlayerHand => singleCardOnPlayerHand;

    
    public Player()
    {
        playerCardsDeck = new PlayerCardsDeck(Game.AmountCards);
    }

    
    public void DrawSingleCardOnPlayerHand()
    {
        Random random = new Random();
        int index = random.Next(playerCardsDeck.GetCards().Count);
        KeyValuePair<string, SingleCard> randomSingleElementAt = playerCardsDeck.GetCards().ElementAt(index);
        singleCardOnPlayerHand = randomSingleElementAt.Value;
    }

    
    // metoda do doszlifowania
    public int ChoseValuFromSingleCardToPlay(int numberValueOnTheCard)
    {
        switch (numberValueOnTheCard)
        {
            case 1:
                return singleCardOnPlayerHand.EngineCapacity;
            case 2:
                return singleCardOnPlayerHand.Acceleration;
            case 3:
                return singleCardOnPlayerHand.EnginePower;
            case 4:
                return singleCardOnPlayerHand.MaxSpeed;
            default:
                Console.WriteLine("Wrong Number");
                break;
        }
        return 0;
    }
    
    }
}