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
        enum Suit
        {
            Club = 1,
            Diamond = 2,
            Heart = 3,
            Spade = 4
        }

        public Deck()
        {



            using (var reader = new StreamReader(@"C:\Users\tyler\Documents\University\Senior\Spring 2020\Programming\PlayingCards.csv"))
            {
                List<Card> deck = new List<Card>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    deck.Add(new Card(values[0], values[1], values[2], values[3]));
                }
            }


        }

    }
}
