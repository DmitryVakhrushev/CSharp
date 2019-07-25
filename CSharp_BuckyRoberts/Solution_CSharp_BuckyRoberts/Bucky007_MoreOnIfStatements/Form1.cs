using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bucky007_MoreOnIfStatements
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            //if(checkBox1.Checked == true) -- use the shorter version
            if (checkBox1.Checked)
            {
                MessageBox.Show("The checkbox is checked");
            }

            bool myBool = true;
            if (myBool)
            {
                MessageBox.Show("myBool is true");
            }

            bool myBool2 = false;
            if (!myBool2)
            {
                MessageBox.Show("myBool2 is false");
            }

            int i = 3;
            int b = 6;
            int c = 0;

            if(i > c)
            {
                MessageBox.Show("I is greater than c");
            }

        }
    }
}
