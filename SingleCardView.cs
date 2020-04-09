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
        
         /*{
            name = _player.Name;
            cardName = _player.SingleCardOnPlayerHand.CarModel;
            EC = _player.SingleCardOnPlayerHand.EngineCapacity;
            MS = _player.SingleCardOnPlayerHand.MaxSpeed;
            AC = _player.SingleCardOnPlayerHand.Acceleration;
            EP = _player.SingleCardOnPlayerHand.EnginePower;  
         }*/

        public void PrintCardWithReplaceData() {

        }

         public void PrintCardOfMainPlayerAtTable(Player player)
         {
             
             Console.WriteLine(
                 
$@"                         __________________                                   
                      __|________________  |                                    
                   __|_________________  | |                                    
                  |~P: {player.Name.PadRight(12)}    | | |                                      
                  |                    | | |                                    
                  |   {player.SingleCardOnPlayerHand.CarModel.PadRight(15)}  | | |                        .------.    
                  |                    | | |     .------.           |S .   |    
                  |   EngineCap: {player.SingleCardOnPlayerHand.EngineCapacity.PadRight(4)}  | | |     |C_  _ |    .------; / \  |    
                  |   MaxSpeed: {player.SingleCardOnPlayerHand.MaxSpeed.PadRight(4)}   | | |     |( \/ )|-----. _   |(_,_) |    
                  | Acceleration: {player.SingleCardOnPlayerHand.Acceleration.Trim().PadRight(4)} | | |     | \  / | /\  |( )  |  I  S|    
                  |  EnginePower: {player.SingleCardOnPlayerHand.EnginePower.PadRight(4)} | | |     |  \/ C|/  \ |_x_) |------'    
                  |                    | | |     `-----+'\  / | Y  R|           
                  |      ______        | | |           |  \/ A|-----'            
                  |     /|_||_\`.__    | | |           `------'                        
                  |    (   _    _ _\   | | |                                   
                  |    =`-(_)--(_)-'   | |_|                                   
                  |                    |_|                                     
                  |_______C.A.R.S______| "
                 
                 );
                }
         
         
         
         public void PrintSingleCard(Player player)
         {
             
          Console.WriteLine(
                 
           $@"                         __________________                                   
                      __|________________  |
                   __|_________________  | |
                  |~P: {player.Name.PadRight(12)}    | | |
                  |                    | | |                                    
                  |   {player.SingleCardOnPlayerHand.CarModel.PadRight(15)}  | | |
                  |                    | | |
                  |   EngineCap: {player.SingleCardOnPlayerHand.EngineCapacity.PadRight(4)}  | | |
                  |   MaxSpeed: {player.SingleCardOnPlayerHand.MaxSpeed.PadRight(4)}   | | |
                  | Acceleration: {player.SingleCardOnPlayerHand.Acceleration.Trim().PadRight(4)} | | |
                  |  EnginePower: {player.SingleCardOnPlayerHand.EnginePower.PadRight(4)} | | |     
                  |                    | | |
                  |      ______        | | |
                  |     /|_||_\`.__    | | |
                  |    (   _    _ _\   | | |
                  |    =`-(_)--(_)-'   | |_|
                  |                    |_|
                  |_______C.A.R.S______| "
                 
          );
         }
         
         public void PrintSingleWinnerCard(Player player)
         {
          Console.ForegroundColor = ConsoleColor.Green;
          Console.WriteLine(
           
                 
           $@"
 __          _______ _   _ _   _ ______ _____  
 \ \        / /_   _| \ | | \ | |  ____|  __ \ 
  \ \  /\  / /  | | |  \| |  \| | |__  | |__) |
   \ \/  \/ /   | | | . ` | . ` |  __| |  _  / 
    \  /\  /   _| |_| |\  | |\  | |____| | \ \ 
     \/  \/   |_____|_| \_|_| \_|______|_|  \_\
                                                                                              
                         __________________                                   
                      __|________________  |
                   __|_________________  | |
                  |~P: {player.Name.PadRight(12)}    | | |
                  |                    | | |                                    
                  |   {player.SingleCardOnPlayerHand.CarModel.PadRight(15)}  | | |
                  |                    | | |
                  |   EngineCap: {player.SingleCardOnPlayerHand.EngineCapacity.PadRight(4)}  | | |
                  |   MaxSpeed: {player.SingleCardOnPlayerHand.MaxSpeed.PadRight(4)}   | | |
                  | Acceleration: {player.SingleCardOnPlayerHand.Acceleration.Trim().PadRight(4)} | | |
                  |  EnginePower: {player.SingleCardOnPlayerHand.EnginePower.PadRight(4)} | | |     
                  |                    | | |
                  |      ______        | | |
                  |     /|_||_\`.__    | | |
                  |    (   _    _ _\   | | |
                  |    =`-(_)--(_)-'   | |_|
                  |                    |_|
                  |_______C.A.R.S______| "
                 
          );
          Console.ForegroundColor = ConsoleColor.White;
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




