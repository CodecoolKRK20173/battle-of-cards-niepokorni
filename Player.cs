using System;

namespace Niepokorni
{
    class Player {
        public string Name { get; set; }
        public Card MyCards { get; set; }

        public Player (string name) {
            this.Name = name;
            this.MyCards = new Card(10); //tu wstępnie taki zapis, bo nie wiem jeszcze jak bedziemy
                                         //zapisywać, że każdy player dostaja 10 kart na start
        }
    }
}