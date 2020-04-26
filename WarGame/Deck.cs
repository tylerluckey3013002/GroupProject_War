using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
namespace WarGame
{
    class Deck
    {
        public int quant { get; set; }
        public List<Card> cards = new List<Card>();
        private const string PATH = "PlayingCards.csv";
        enum Suit
        {
            Club = 1,
            Diamond = 2,
            Heart = 3,
            Spade = 4
        }

        public Deck()
        {
            var file = File.ReadAllLines("PlayingCards.csv");
            List<Card> deck = new List<Card>();
            for (int i = 1; i < file.Length; i++) // start at 1 to skip first line
            {
                var line = file[i].Split(','); 
                deck.Add(new Card(line[0], line[1], line[2], line[3]));

            }
        }

    }
}
