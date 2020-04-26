using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame
{
    class Deck
    {
        public int quant { get; set; }
        public List<Card> cards = new List<Card>();

        enum Suit
        {
            Heart = 1,
            Club = 2,
            Diamond = 3,
            Spade = 4
        }

        public Deck()
        {
            for(int i = 1;i < 13; i++)
            {

            }
        }

    }
}
