using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace Niepokorni
{
    class Program
    {
        public enum Status {START, CREATE_PLAYERS, PLAY, WIN, BEST_SCORES, HOW_TO_PLAY, EXIT }
        static bool theGameIsOver = false;
		static Status gameStatus = Status.START;
        static Player[] playersObjects = new Player[4];
        static List <string> playersNamesInitial = new List<string> { "Player1", "Player2", "Player3", "Player4" };

        static void Main(string[] args)
        {
			while (!theGameIsOver) {

				switch (gameStatus) {

					case Status.START:
						Console.Title = "Battle of Cards";
						for (int i = Console.WindowWidth - 50; i >= 0; i--) {
							Console.Clear();
							Game.StartScreenDisplay(i);
							Thread.Sleep(20);
						}
						CenterAlign("Welcome in Battle of Cards"); 
						System.Console.WriteLine("\n\n");
						CenterAlign("MENU:\n"); 
						System.Console.WriteLine();
						CenterAlign(":: 1 ::  Play\n");
						CenterAlign(":: 2 ::  Best scores\n");
						CenterAlign(":: 3 ::  How to play\n");
                        CenterAlign(":: 4 ::  Exit\n");

						string choice = Console.ReadLine();
						if (choice == "1") {
							gameStatus = Status.CREATE_PLAYERS; }
						else if (choice == "2") {
							gameStatus = Status.BEST_SCORES; }
						else if (choice == "3") {
							gameStatus = Status.HOW_TO_PLAY; }
                        else if (choice == "4") {
							gameStatus = Status.EXIT; }
						else {
							Console.WriteLine("Choose a right option from menu.");}
						break;

					case Status.CREATE_PLAYERS:
                    //odnosnik do metody z wyborem liczby graczy i przypisania imion
                    //Game.TakeCardsToStart();  <-- metoda do losowania kart na start
						
						gameStatus = Status.PLAY;
						break;

					case Status.PLAY:
                        bool winStatus = false;
                        foreach (string player in playersObjects) {

						//metody do grania


                        /* if (player has won) {  
                        winStatus = true;
						gameStatus = Status.WIN;
                        winnerName = player.Name;
						break; */

                        }
                        break;

                    case Status.WIN:
                        Console.Clear();
                        Console.WriteLine($"\nCongrats!! {winnerName} - You are a winner!");
                        Thread.Sleep(5000);
                        gameStatus = Status.START;
                        break;
					
					case Status.EXIT:
						Console.Clear();
						Console.WriteLine();
						theGameIsOver = true;
						break;
				}
			}
		} 
    }
}
