using System;

namespace CardGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            Game newGame = new Game("Gra w Mirka", 3, 20);
            Console.WriteLine(newGame.NameOfTheGame);
            newGame.Players[0].DrawSingleCardOnPlayerHand();
            Console.WriteLine();
            newGame.Players[0].SingleCardOnPlayerHand;


        }
    }
}