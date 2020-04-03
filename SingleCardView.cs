using System;
using System.Collections.Generic;

namespace CardGame
{
     public class SingleCardView
     {
         public string CardTheme;
         private string cardName;
        private string EC;
        private string MS;
        private string AC;
        private string EP;
        private Player _player;
        private string name;

         public SingleCardView()
         {
            name = _player.Name;
            cardName = _player.SingleCardOnPlayerHand.CarModel;
            EC = _player.SingleCardOnPlayerHand.EngineCapacity;
            MS = _player.SingleCardOnPlayerHand.MaxSpeed;
            AC = _player.SingleCardOnPlayerHand.Acceleration;
            EP = _player.SingleCardOnPlayerHand.EnginePower;  
         }

         public void PrintPlayerCard()
         {
             //chcę na górze karty dać tylko nr gracza, który aktualnie będzie wybierał kartę, nie wiem czy robimy playerów po indexach?

             Console.WriteLine(
                 
                 $@"     __________________                                     \n 
                      __|________________  |                                    \n
                   __|_________________  | |                                    \n
                  |~P: {name}          | | |                                    \n  
                  |                    | | |                                    \n
                  |     {cardName}     | | |                        .------.    \n
                  |                    | | |     .------.           |S .   |    \n
                  |   EngineCap:{EC}   | | |     |C_  _ |    .------; / \  |    \n
                  |   MaxSpeed:{MS}    | | |     |( \/ )|-----. _   |(_,_) |    \n
                  |  Acceleration:{AC} | | |     | \  / | /\  |( )  |  I  S|    \n
                  |  EnginePower:{EP}  | | |     |  \/ C|/  \ |_x_) |------'    \n
                  |                    | | |     `-----+'\  / | Y  R|           \n
                  |      ______        | | |           |  \/ A|-----'           \n   
                  |     /|_||_\`.__    | | |           `------'                 \n        
                  |    (   _    _ _\   | | |                                    \n
                  |    =`-(_)--(_)-'   | |_|                                    \n
                  |                    |_|                                      \n
                  |____𝕭𝖆𝖙𝖙𝖑𝖊_𝖔𝖋_𝕮𝖆𝖗𝖉𝖘____| "
                 
                 );
                }


        /*
         public readonly List<string> PlayerCardsToPrint = new List<string>  {
             
         "        __________________ ",
         "     __|________________  |",
         "  __|_________________  | |",
         " |                    | | |",
         " |     CARD NAME      | | |",
         " |                    | | |",
         " |   EngineCap: EC    | | |",
         " |   MaxSpeed: MS     | | |",
         " |  Acceleration: AC  | | |",
         " |  EnginePower: EP   | | |",
         " |                    | | |",
         " |      ______        | | |",
        @" |     /|_||_\`.__    | | |",
        @" |    (   _    _ _\   | | |",
         " |    =`-(_)--(_)-'   | |_|",
         " |                    |_|",
        @" |____𝕭𝖆𝖙𝖙𝖑𝖊_𝖔𝖋_𝕮𝖆𝖗𝖉𝖘____| ",
         };

        */



         /*
         public void PrintPlayersCards() {
             foreach (string line in PlayerCardsToPrint) {
                 System.Console.WriteLine(line);
             }
         }
         */
         
         
     }
}




