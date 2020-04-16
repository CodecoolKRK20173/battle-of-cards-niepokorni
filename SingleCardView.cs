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
                      __|________________  |                                                Wybierz na co chcesz walczyć:
                   __|_________________  | |                                    
                  |Player: {name.PadRight(8)}    | | |                                                1. Engine Cap {EC}
                  |                    | | |                                                2. Max Speed {MS}
                  |   {cardName.PadRight(15)}  | | |                        .------.                3. Acceleration {AC}
                  |                    | | |     .------.           |S .   |                4. Engine Power {EP}
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
        // Player player = new Player();
        

        //     Console.WriteLine();
        //     Console.Write("Choose option: ");

        //     string choice = Console.ReadLine();

        //     if(choice == "1")
        //     {
        //         Console.WriteLine(EC);
        //         Console.ForegroundColor = ConsoleColor.Yellow;
        //         Console.WriteLine(player.SingleCardOnPlayerHand.EngineCapacity);
        //         Console.ResetColor();
        //         if (int.Parse(EC) > int.Parse(player.SingleCardOnPlayerHand.EngineCapacity))
        //         {
        //             Console.WriteLine($"{name} " + "wins");
        //             PrintCardWithReplaceData();
        //         }
        //         else
        //         {
        //             Console.WriteLine($"{game.Players[1]} " + "wins");
        //             PrintCardWithReplaceData();
        //         }
                
        //     }
        //     else if(choice == "2")
        //     {
        //         Console.WriteLine(MS);
        //         Console.ForegroundColor = ConsoleColor.Yellow;
        //         Console.WriteLine(player.SingleCardOnPlayerHand.MaxSpeed);
        //         Console.ResetColor();
        //         if (int.Parse(MS) > int.Parse(player.SingleCardOnPlayerHand.MaxSpeed))
        //         {
        //             Console.WriteLine($"{name} " + "wins");
        //             Console.WriteLine();
        //         }
        //     }
        //     else if(choice == "3")
        //     {
        //         Console.WriteLine(AC);
        //         Console.ForegroundColor = ConsoleColor.Yellow;
        //         Console.WriteLine(player.SingleCardOnPlayerHand.Acceleration);
        //         Console.ResetColor();
        //     }
        //     else if(choice == "4")
        //     {
        //         Console.WriteLine(EP);
        //         Console.ForegroundColor = ConsoleColor.Yellow;
        //         System.Console.WriteLine(player.SingleCardOnPlayerHand.EnginePower);
        //         Console.ResetColor();
        //     }
     
        }
    }        
}






