using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bucky005_ChangingPropertiesWithCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Adam";
            button1.Height = 60;
            button1.Enabled = false;

            textBox1.Text = "Adam";
            textBox1.MaxLength = 2;
        }
    }
}
