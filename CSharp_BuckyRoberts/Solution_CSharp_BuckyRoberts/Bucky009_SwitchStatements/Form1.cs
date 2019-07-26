using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bucky009_SwitchStatements
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            switch(textBox1.Text)
            {
                case "Adam":
                    MessageBox.Show("Hello");
                    break;
                case "Bob":
                    MessageBox.Show("yo");
                    break;
                default:
                    MessageBox.Show("Your name isn't important");
                    break;
            }

            int i = 16;
            switch(i)
            {
                case 4:
                    MessageBox.Show("You are too young");
                    break;
                case 16:
                    MessageBox.Show("You can drive");
                    break;
            }

        }
    }
}
