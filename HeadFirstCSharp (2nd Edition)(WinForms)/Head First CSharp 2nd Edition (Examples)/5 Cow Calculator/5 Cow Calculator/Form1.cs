using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace __Cow_Calculator
{
    public partial class Form1 : Form
    {
        Farmer farmer;

        public Form1() {
            InitializeComponent();
            farmer = new Farmer(15, 30);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            farmer.NumberOfCows = (int)numericUpDown1.Value;
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            Console.WriteLine("I need {0} bags of feed for {1} cows",
                farmer.BagsOfFeed, farmer.NumberOfCows);
        }

        private void setBags_Click(object sender, EventArgs e)
        {
            // This button no longer works, because we converted BagsOfFeed
            // to a read-only property.
            //
            // farmer.BagsOfFeed = 5;
        }
    }
}
