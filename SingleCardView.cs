
using System;
using System.Collections.Generic;

namespace CardGame
{
     public class SingleCardView
     {
         public string CardTheme;

         private SingleCard _singleCard;

         private string nameCard;
         

         public SingleCardView()
         {
             nameCard = _singleCard.CarModel;
         }
         

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


         public void print()
         {
             Console.WriteLine(""
                 
                 $@"        _________________\n 
                      __|________________  |\n
                   __|_________________  | |\n
                  |      {nameCard}              | | |\n
                  |     CARD NAME      | | |\n
                  |                    | | |\n
                  |   EngineCap: EC    | | |\n
                  |   MaxSpeed: MS     | | |\n
                  |  Acceleration: AC  | | |\n
                  |  EnginePower: EP   | | |\n
                  |                    | | |\n
                  |      ______        | | |\n
                  |     /|_||_\`.__    | | |\n
                  |    (   _    _ _\   | | |\n
                  |    =`-(_)--(_)-'   | |_|\n
                  |                    |_|\n
                  |____𝕭𝖆𝖙𝖙𝖑𝖊_𝖔𝖋_𝕮𝖆𝖗𝖉𝖘____| "
                 
                 );
         }

         public void PrintPlayersCards() {
             foreach (string line in PlayerCardsToPrint) {
                 System.Console.WriteLine(line);
             }
         }
         
         
         

         public void ReplaceNameCard(Card card ) {
             string stringToReplace = "CARD NAME";
             string stringAfterReplace = $"{Card.Card.Name}"; 
         }
     }
}



