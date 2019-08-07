using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace __Card_Comparer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random random = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Five random cards:");
            List<Card> cards = new List<Card>();
            for (int i = 0; i < 5; i++)
            {
                cards.Add(new Card((Card.Suits)random.Next(4),
                                   (Card.Values)random.Next(1, 14)));
                Console.WriteLine(cards[i].Name);
            }

            Console.WriteLine("Those same cards, sorted:");
            cards.Sort(new CardComparer_byValue());
            foreach (Card card in cards)
            {
                Console.WriteLine(card.Name);
            }
        }

    }
}