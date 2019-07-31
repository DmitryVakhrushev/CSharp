using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bucky014_DoAndDoWhileLoop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < 10) // while (true) creates an infinite loop
            {
                textBox1.Text += i.ToString();
                i++;
            }

            //DO-WHILE executes the code at least once
            do
            {
                textBox1.Text += i.ToString();
                i++;
            }
            while (i < 10);
        }
    }
}
