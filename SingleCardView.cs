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

        public void PrintCardWithReplaceData() {

        }

         public void PrintPlayerCard()
         {
             
             Console.WriteLine(
                 
                 $@"     __________________                                     \n 
                      __|________________  |                                    \n
                   __|_________________  | |                                    \n
                  |~P: {name:12}    | | |                                    \n  
                  |                    | | |                                    \n
                  |   {cardName:13}    | | |                        .------.    \n
                  |                    | | |     .------.           |S .   |    \n
                  |   EngineCap:{EC:4} | | |     |C_  _ |    .------; / \  |    \n
                  |   MaxSpeed:{MS:4}  | | |     |( \/ )|-----. _   |(_,_) |    \n
                  | Acceleration:{AC:4} | | |     | \  / | /\  |( )  |  I  S|    \n
                  |  EnginePower:{EP:4} | | |     |  \/ C|/  \ |_x_) |------'    \n
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




