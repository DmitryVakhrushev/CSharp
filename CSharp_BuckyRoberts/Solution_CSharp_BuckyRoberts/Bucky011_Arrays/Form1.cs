using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bucky011_Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Define a string array with hardcoded values
            string[] Names = { "Adam", "Bob", "Joe" };
            MessageBox.Show(Names[0]);

            // Define a string array with up to 5 members
            string[] Fruits = new string[5];
            Fruits[0] = "Banana";
            MessageBox.Show(Fruits[0]);

            // Define an integer array with hardcoded values
            int[] Numbers = { 123, 456, 789 };
            MessageBox.Show(Numbers[1].ToString());
        }
    }
}
