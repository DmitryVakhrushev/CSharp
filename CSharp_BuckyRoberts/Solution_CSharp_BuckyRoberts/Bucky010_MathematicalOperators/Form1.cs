using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bucky010_MathematicalOperators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int a = 5;
            int b = 3;

            MessageBox.Show((a + b).ToString());

            a = a + 7;
            a += 7;

            MessageBox.Show(a.ToString());

            a = a + 1;
            a++; //increment a by 1

            MessageBox.Show(a.ToString());

            --a; //decrement by 1 first
        }

    }
}
