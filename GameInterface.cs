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
							StartScreenDisplay(i);
							Thread.Sleep(20);
						}

						CenterAlign("Welcome in Battle of Cards");

						CenterAlign("MENU:\n");

						CenterAlign(":: 1 ::  Play\n");
						CenterAlign(":: 2 ::  Best scores\n");
						CenterAlign(":: 3 ::  How to play\n");
						CenterAlign(":: 4 ::  Exit");

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
						else
						{
							Console.WriteLine("Choose a right option from menu.");
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

						Game carBattleOfCards = new Game(nameOfTheGame, numberOfPlayers, amountCards);
						int index = 0;
						foreach (var player in carBattleOfCards.Players)
						{
							player.Name = playersName[index];
							index++;
						}
						_gameStatus = Status.PLAY;
						break;

					/*case Status.PLAY:
                         bool winStatus = false;
                         foreach (string player in playersObjects) {

						//metody do grania


                          if (player has won) {  
                         winStatus = true;
						_gameStatus = Status.WIN;
                         winnerName = player.Name;
						break; 
                           }

						 }
                         break;

                     case Status.WIN:
                         Console.Clear();
                         Console.WriteLine($"\nCongrats!! {winnerName} - You are a winner!");
                         Thread.Sleep(5000);
                         _gameStatus = Status.START;
                         break;
					
					case Status.EXIT:
						Console.Clear();
						Console.WriteLine();
						_theGameIsOver = true;
						break;*/
				}
		}


		public void StartScreenDisplay(int textNiepokorniCards)
		{
			System.Console.WriteLine("\t\tLet's play a serious game, mate!");
			System.Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t TEST TEST CZY TO WIDAĆ? ");

			// Console.SetCursorPosition(textShift, (Console.WindowHeight/2));
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
	}
}

		