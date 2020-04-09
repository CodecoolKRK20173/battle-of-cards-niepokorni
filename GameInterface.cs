using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace CardGame
{
	class GameInterface
	{
		public enum Status
		{
			START,
			CREATE_GAME,
			PLAY,
			WIN,
			BEST_SCORES,
			HOW_TO_PLAY,
			EXIT
		}

		static bool _theGameIsOver = false;
		static Status _gameStatus = Status.START;
		private List<string > playersName = new List<string>();
		private Game _game;


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
						for (int i = Console.WindowWidth - 50; i >= 0; i--)
						{
							Console.Clear();
							PrintPlayersCards();
							//StartScreenDisplay(i);
							//Thread.Sleep(20);
						}
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
						if (choice == "1")
						{
							_gameStatus = Status.CREATE_GAME;
						}
						else if (choice == "2")
						{
							_gameStatus = Status.BEST_SCORES;
						}
						else if (choice == "3")
						{
							_gameStatus = Status.HOW_TO_PLAY;
						}
						else if (choice == "4")
						{
							_gameStatus = Status.EXIT;
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
						
						Console.WriteLine("Write amount of Cards for Player");
						int amountCards = int.Parse(Console.ReadLine());

						_game = new Game(nameOfTheGame, numberOfPlayers, amountCards);
						int index = 0;
						foreach (var player in _game.Players)
						{
							player.Name = playersName[index];
							index++;
						}

						_game.Players[0].StatusOfWinning = true;
						_gameStatus = Status.PLAY;
						break;

					case Status.PLAY:
						var playerWhoStart = _game.PlayingTable.GetWinningPlayer(); //ustawienia gracza rozgrywającego
						SingleCardView playerSingleCardView = new SingleCardView(playerWhoStart);
						playerSingleCardView.PrintPlayerCard();
						Console.ReadLine();
						
						break;

                     case Status.WIN:
                         Console.Clear();
                         Console.WriteLine($"\nCongrats!!  - You are a winner!");
                         Thread.Sleep(5000);
                         _gameStatus = Status.START;
                         break;
					
					case Status.EXIT:
						Console.Clear();
						Console.WriteLine();
						_theGameIsOver = true;
						break;
				}
		}

         public void PrintPlayersCards() {
             foreach (string line in PlayerCardsToPrint) {
                 CenterAlign(line);
             }}

		public readonly List<string> PlayerCardsToPrint = new List<string>  {
             
				@".------..------..------..------..------..------..------..------..------..------.",
				@"|N.--. ||I.--. ||E.--. ||P.--. ||O.--. ||K.--. ||O.--. ||R.--. ||N.--. ||I.--. |",
				@"| :(): || (\/) || (\/) || :/\: || :/\: || :/\: || :/\: || :(): || :(): || (\/) |",
				@"| ()() || :\/: || :\/: || (__) || :\/: || :\/: || :\/: || ()() || ()() || :\/: |",
				@"| '--'N|| '--'I|| '--'E|| '--'P|| '--'O|| '--'K|| '--'O|| '--'R|| '--'N|| '--'I|",
				@"`------'`------'`------'`------'`------'`------'`------'`------'`------'`------",
				"\n\n"
         };	 


		/*
		public void StartScreenDisplay(int textNiepokorniCards)
		{
			System.Console.WriteLine("\t\tLet's play a serious game, mate!");
			System.Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t TEST TEST CZY TO WIDAĆ? ");

			string[] NiepokorniASCII =
			{
				@".------..------..------..------..------..------..------..------..------..------.",
				@"|N.--. ||I.--. ||E.--. ||P.--. ||O.--. ||K.--. ||O.--. ||R.--. ||N.--. ||I.--. |",
				@"| :(): || (\/) || (\/) || :/\: || :/\: || :/\: || :/\: || :(): || :(): || (\/) |",
				@"| ()() || :\/: || :\/: || (__) || :\/: || :\/: || :\/: || ()() || ()() || :\/: |",
				@"| '--'N|| '--'I|| '--'E|| '--'P|| '--'O|| '--'K|| '--'O|| '--'R|| '--'N|| '--'I|",
				@"`------'`------'`------'`------'`------'`------'`------'`------'`------'`------'"
			};
			foreach (string niepokorniLine in NiepokorniASCII)
			{
				Console.SetCursorPosition(textNiepokorniCards, Console.CursorTop);
				System.Console.WriteLine(niepokorniLine);
				
			}
		}

		*/
	}
}

		