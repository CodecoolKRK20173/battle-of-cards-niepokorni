using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CardGame
{
	class GameInterface
	{
		private enum Status
		{
			START,
			CREATE_GAME,
			PLAY,
			WIN,
			BEST_SCORES,
			HOW_TO_PLAY,
			EXIT
		}

		private static bool _theGameIsOver = false;
		private Status _gameStatus = Status.START;
		private List<string > playersName = new List<string>();
		private Game _game;
		private SingleCardView singleCardView = new SingleCardView();


		public static void CenterAlign(string text)
		{
			Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (text.Length / 2)) + "}", text));
		}


		public void StartGame()
		{
			while (!_theGameIsOver)
				switch (_gameStatus)
				{

					case Status.START:
						Console.Title = "Battle of Cards";
						PrintPlayersCards();
						Console.ForegroundColor = ConsoleColor.Blue;
						CenterAlign("Welcome in Battle of Cards by NIEPOKORNI!\n");
						Console.ForegroundColor = ConsoleColor.Magenta;
						CenterAlign("M E N U\n");
						Console.ForegroundColor = ConsoleColor.DarkGreen;
						CenterAlign(":: 1 ::  Play  ::            \n");
						CenterAlign(":: 2 ::  Best scores  ::     \n");
						CenterAlign(":: 3 ::  How to play  ::     \n");
						CenterAlign(":: 4 ::  Exit  ::             ");
						Console.WriteLine();
						Console.WriteLine();
						Console.Write("Choose a right option from menu: ");
						Console.ResetColor();

						string choice = Console.ReadLine();
						switch (choice)
						{
							case "1":
								_gameStatus = Status.CREATE_GAME;
								break;
							case "2":
								_gameStatus = Status.BEST_SCORES;
								break;
							case "3":
								_gameStatus = Status.HOW_TO_PLAY;
								break;
							case "4":
								_gameStatus = Status.EXIT;
								break;
							default:
								Console.WriteLine("Choose a right option from menu.");
								break;
						}

						break;


					case Status.CREATE_GAME:

						Console.WriteLine("Write name of the game:");
						string nameOfTheGame = Console.ReadLine();
						
						Console.WriteLine("How many players ? ");
						int numberOfPlayers = int.Parse(Console.ReadLine());
						for (int i = 0; i < numberOfPlayers; i++)
						{
							Console.WriteLine( $"Write  name for Player nr {i+1} ?");
							string playerName = Console.ReadLine();
							playersName.Add(playerName);
						}
						
						Console.WriteLine("How many rounds do you want to play?");
						int amountCards = int.Parse(Console.ReadLine());

						_game = new Game(nameOfTheGame, numberOfPlayers, amountCards);

						//add names for players
						int index = 0;
						foreach (var player in _game.Players)
						{
							player.Name = playersName[index];
							index++;
						}
						
						_game.Players[0].StatusOfWinning = true; //declare player who start the game
						Console.Clear();
						
						_gameStatus = Status.PLAY;
						break;

					
					case Status.PLAY:
						Player winningPlayer = _game.PlayingTable.GetWinningPlayer();
						Console.WriteLine($"Hi {winningPlayer.Name}");
						Console.WriteLine("Choose value of your Card for the Battle");
						singleCardView.PrintCardOfMainPlayerAtTable(winningPlayer);
						string chosenCardValueByPlayer = Console.ReadLine();
						Console.Clear();
						winningPlayer = _game.PlayingTable.CompareValueOnPlayersCarts(chosenCardValueByPlayer);
						singleCardView.printAllCardsFromBattle(_game);
						singleCardView.PrintSingleWinnerCard(winningPlayer);
						Console.WriteLine("The winner is:");
						Console.WriteLine(winningPlayer.Name);
						Console.WriteLine();
						_game.PlayingTable.AddCardsForWinningPlayer(winningPlayer);
						if (_game.PlayingTable.CheckIsSomePlayersCardsDeckIsEmpty())
						{
							_gameStatus = Status.WIN;
							break;
						}
						_game.PlayingTable.DrawNewSingleCardsOnPlayersHands();
						_game.PlayingTable.GetListWithWinningCardsDeckPlayers();
						break;
					
                     case Status.WIN:
                         Console.Clear();
                         
                         Console.WriteLine($" {_game.PlayingTable.GetWinningPlayer().Name} \nCongrats!!  - You are a winner!");
                         Console.ReadKey();
                         _gameStatus = Status.START;
                         break;
					
					case Status.EXIT:
						Console.Clear();
						Console.WriteLine();
						_theGameIsOver = true;
						break;
				}
		}

		
		
		private void PrintPlayersCards()
         {
             foreach (string line in PlayerCardsToPrint)
             {
	             CenterAlign(line);
             }
         }

		public readonly List<string> PlayerCardsToPrint = new List<string>  {
             
				@".------..------..------..------..------..------..------..------..------..------.",
				@"|N.--. ||I.--. ||E.--. ||P.--. ||O.--. ||K.--. ||O.--. ||R.--. ||N.--. ||I.--. |",
				@"| :(): || (\/) || (\/) || :/\: || :/\: || :/\: || :/\: || :(): || :(): || (\/) |",
				@"| ()() || :\/: || :\/: || (__) || :\/: || :\/: || :\/: || ()() || ()() || :\/: |",
				@"| '--'N|| '--'I|| '--'E|| '--'P|| '--'O|| '--'K|| '--'O|| '--'R|| '--'N|| '--'I|",
				@"`------'`------'`------'`------'`------'`------'`------'`------'`------'`------",
		};
	}
}

		