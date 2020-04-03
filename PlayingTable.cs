using System;
using System.Collections.Generic;

namespace CardGame
{
    public class PlayingTable
    {
        private readonly Game _game;


        public PlayingTable(Game game)
        {
            this._game = game;
        }

        
        public void CompareValuesOnPlayersCarts(Game game)
        {
           
        }

        public Player GetWinningPlayer()
        {
            Player winningPlayer = _game.Players[0];
            for (int i = 0; i < _game.GetNumersOfPlayers(); i++)
            {
                if (_game.Players[i].StatusOfWinning == true)
                {
                    winningPlayer=_game.Players[i];
                }
            }
            return winningPlayer;
        }
        
        }
}