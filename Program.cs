using System;
using System.Linq;
namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            GameInterface newGame = new GameInterface();
            newGame.StartGame();
        }
    }
}