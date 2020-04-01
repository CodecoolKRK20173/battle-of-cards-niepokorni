using System;
using System.Reflection.Metadata;

namespace CardGame
{
    class Player

    {
    private string name;
    private PlayerCardsDeck playerCardsDeck;
    private SingleCardGame _singleCardGameOnPlayerHand;
    

    public Player()
    {
        playerCardsDeck = new PlayerCardsDeck(Game.AmountCards);
    }
    }
}