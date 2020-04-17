using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;

namespace CardGame
{
    public class PlayingTable
    {
        private Game _game;


        public PlayingTable(Game game)
        {
            this._game = game;
        }


        public Player CompareValueOnPlayersCarts(string chosenCardValueByPlayer)
        {
            var winningPlayer = _game.Players[0];
            switch (chosenCardValueByPlayer)
            {
                case "1":
                    var maxEngineCapacityValueFromPlayersCards =
                        _game.Players.Max(player => int.Parse(player.SingleCardOnPlayerHand.EngineCapacity));
                    
                    foreach (var PLAYER in _game.Players)
                    {
                        if (int.Parse(PLAYER.SingleCardOnPlayerHand.EngineCapacity) == maxEngineCapacityValueFromPlayersCards)
                            winningPlayer = PLAYER;
                    }
                    break;
                case "2":
                    var maxSpeedValueFromPlayersCards =
                        _game.Players.Max(player => int.Parse(player.SingleCardOnPlayerHand.MaxSpeed));
                    
                    foreach (var PLAYER in _game.Players)
                    {
                        if (int.Parse(PLAYER.SingleCardOnPlayerHand.MaxSpeed) == maxSpeedValueFromPlayersCards)
                            winningPlayer = PLAYER;
                    }
                    break;
                case "3":
                    var maxAccelerationValueFromPlayersCards =
                        _game.Players.Min(player => Convert.ToDouble(player.SingleCardOnPlayerHand.Acceleration, CultureInfo.InvariantCulture));
                    
                    foreach (var PLAYER in _game.Players)
                    {
                        if (Convert.ToDouble(PLAYER.SingleCardOnPlayerHand.Acceleration, CultureInfo.InvariantCulture) == maxAccelerationValueFromPlayersCards)
                            winningPlayer = PLAYER;
                    }
                    break;
                case "4":
                    var maxEnginePoweValueFromPlayersCards =
                        _game.Players.Max(player => int.Parse(player.SingleCardOnPlayerHand.EnginePower));
                    
                    foreach (var PLAYER in _game.Players)
                    {
                        if (int.Parse(PLAYER.SingleCardOnPlayerHand.EnginePower) == maxEnginePoweValueFromPlayersCards)
                            winningPlayer = PLAYER;
                    }
                    break;
            }
            ResetStatusOfWiningForAllPlayers();
            winningPlayer.StatusOfWinning = true;
            return winningPlayer;
        }


        public Player GetWinningPlayer()
        {
            Player winningPlayer = _game.Players[0];

            foreach (var PLAYER in _game.Players)
            {
                if (PLAYER.StatusOfWinning == true)
                {
                    winningPlayer = PLAYER;
                }
            }
            return winningPlayer;
        }

        
        public void DrawNewSingleCardsOnPlayersHands()
        {
            foreach (var PLAYER in _game.Players)
            {
                PLAYER.DrawSingleCardOnPlayerHand();
            }
        }

        
        public void AddCardsForWinningPlayer(Player winningPlayer)
        {
            foreach (var PLAYER in _game.Players)
            {
                winningPlayer.PlayerWinningCardsDeck.Add(PLAYER.SingleCardOnPlayerHand);
            }
        }


        public IOrderedEnumerable<Player> GetListWithWinningPlayers()
        {
            var listWithWinningPlayers = _game.Players.OrderByDescending(p => p.PlayerWinningCardsDeck.Count);
            return listWithWinningPlayers;
        }

        
        public void PrintListWithWinningPlayers()
        {
            var temp = 1;
            Console.WriteLine("SCORES");
            Console.WriteLine("######################################################");
            foreach (var player in GetListWithWinningPlayers())
            {
                Console.WriteLine($"{temp}. {player.Name} have {player.PlayerWinningCardsDeck.Count} winning Cards");
                temp++;
            }
            Console.WriteLine("######################################################");
        }


        public string GetWinnerAtTheEndGame()
        {
            var winnerList = _game.PlayingTable.GetListWithWinningPlayers();
            return winnerList.First().Name;
        }
        
        
        public bool CheckIsSomePlayersCardsDeckIsEmpty()
        {
            bool playersCardsDeckIsEmpty = false;
            foreach (var player in _game.Players)
            {
                if (player.PlayerCardsDeck.GetCards().Count == 0)
                {
                    playersCardsDeckIsEmpty = true;
                }
            }
            return playersCardsDeckIsEmpty;
        }


        private void ResetStatusOfWiningForAllPlayers()
        {
            foreach (var PLAYER in _game.Players)
            {
                PLAYER.StatusOfWinning = false;
            }
        }
        
        
        }
}