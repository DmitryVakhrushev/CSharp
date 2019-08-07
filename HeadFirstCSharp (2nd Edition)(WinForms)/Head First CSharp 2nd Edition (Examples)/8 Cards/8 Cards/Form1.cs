using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace __Cards
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Card card = new Card((Card.Suits)random.Next(4), (Card.Values)random.Next(1, 14));
            MessageBox.Show(card.Name);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Collections.ArrayList l = new System.Collections.ArrayList();
            l.Add(123);
            l.Add("xyz");

            

        }
    }
}
