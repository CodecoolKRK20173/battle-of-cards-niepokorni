using System;

namespace Niepokorni
{
    class Player {
        public string Name { get; set; }
        public Card PlayerCardsDeck { get; set; }
        private Hand SingleCardGame { get; set; }

        public Player (string name) {
            this.Name = name;
            this.PlayerCardsDeck = new Card(10); //tu wstępnie taki zapis, bo nie wiem jeszcze jak bedziemy
                                         //zapisywać, że każdy player dostaja 10 kart na start
            this.SingleCardGame = new Hand();
        }

        
    }
}