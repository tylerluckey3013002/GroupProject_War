using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Create Deck and two random numbers
            List<Card> deck = new List<Card>();
            Random rnd = new Random();
            int random = rnd.Next(deck.Count);

            //Creating List for each players cards to be stored in.
            List<Card> player = new List<Card>();
            List<Card> opponent = new List<Card>();

            //Import Csv file into a deck of cards
            var file = File.ReadAllLines(@"C:\Users\tyler\Documents\University\Senior\Spring 2020\Programming\PlayingCards.csv");
            for (int i = 1; i < file.Length; i++) // start at 1 to skip first line
            {
                var line = file[i].Split(','); //id|suit|rank|url
                deck.Add(new Card(line[0], line[1], line[2], line[3]));
            }

            int halfDeck = deck.Count / 2;
            while (deck.Count > halfDeck)
            {
                rnd = new Random();
                random = rnd.Next(deck.Count);
                player.Add(deck[random]);
                deck.RemoveAt(random);
            }

            while (deck.Count > 0)
            {
                rnd = new Random();
                random = rnd.Next(deck.Count);
                opponent.Add(deck[random]);
                deck.RemoveAt(random);
            }

            rnd = new Random();
            random = rnd.Next(player.Count);
            int random2 = rnd.Next(opponent.Count);

            string playerUrl = player[random].url;
            string oppUrl = opponent[random2].url;
            //Display image of Players Card
            Uri playerUri = new Uri(playerUrl);
            Uri oppUri = new Uri(oppUrl);
            playerCard.Source = new BitmapImage(playerUri);
            opponentCard.Source = new BitmapImage(oppUri);

            playerDesc.Text = player[random].ToString();
            oppDesc.Text = opponent[random2].ToString();

            int pNum = Convert.ToInt32(player[random].id.Remove(0,1));
            int oNum = Convert.ToInt32(opponent[random2].id.Remove(0,1));

            if (pNum > oNum)
            {
                outcome.Text = player[random] + " Beats " + opponent[random2];
            }

            else if (pNum < oNum)
            {
                outcome.Text = player[random] + " Loses to " + opponent[random2];
            }

            else
            {
                outcome.Text = "WAR!!!";
            }
        }
    }
}
