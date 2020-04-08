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
        private string name;

         public SingleCardView(Player _player)
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
                 
$@"                         __________________                                   
                      __|________________  |                                    
                   __|_________________  | |                                    
                  |~P: {name.PadRight(12)}    | | |                                      
                  |                    | | |                                    
                  |   {cardName.PadRight(15)}  | | |                        .------.    
                  |                    | | |     .------.           |S .   |    
                  |   EngineCap: {EC.PadRight(4)}  | | |     |C_  _ |    .------; / \  |    
                  |   MaxSpeed: {MS.PadRight(4)}   | | |     |( \/ )|-----. _   |(_,_) |    
                  | Acceleration: {AC.PadRight(4)} | | |     | \  / | /\  |( )  |  I  S|    
                  |  EnginePower: {EP.PadRight(4)} | | |     |  \/ C|/  \ |_x_) |------'    
                  |                    | | |     `-----+'\  / | Y  R|           
                  |      ______        | | |           |  \/ A|-----'            
                  |     /|_||_\`.__    | | |           `------'                        
                  |    (   _    _ _\   | | |                                   
                  |    =`-(_)--(_)-'   | |_|                                   
                  |                    |_|                                     
                  |_______C.A.R.S______| "
                 
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




