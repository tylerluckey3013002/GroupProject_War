using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame
{
    class Card
    {
        public char suit { get; set; }
        public int rank { get; set; }
        public int num{ get; set;}

        public Card(char suit, int rank, int num)
        {
            this.suit = suit;
            this.rank = rank;
            this.num = num;
        }
    }
}
