//Tyler Luckey
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame
{
    class Card
    {
        public int id { get; set; }
        public string suit { get; set; }
        public string rank { get; set;}
        public string url { get; set; }


        public Card()
        {
            this.id = 0;
            this.suit = string.Empty;
            this.rank = string.Empty;
            this.url = string.Empty;
        }
        public Card(string id, string suit, string rank, string url)
        {
            this.id = Convert.ToInt32(id);
            this.suit = suit;
            this.rank = rank;
            this.url = url;
        }

        public override string ToString()
        {
            return "{rank} of {suit}s";
        }
    }
}
