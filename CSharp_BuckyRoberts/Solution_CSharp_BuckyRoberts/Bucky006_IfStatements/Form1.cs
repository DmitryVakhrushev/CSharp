using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bucky006_IfStatements
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "Adam") // !=, 
            {
                MessageBox.Show("Hello");
            }

            else if(textBox1.Text == "Bob")
            {
                MessageBox.Show("yo");
            }

            else if (textBox1.Text == "Joe")
            {
                MessageBox.Show("Hi");
            }
            else
            {
                MessageBox.Show("Sorry, your name is not important");
            }
        }
    }
}
