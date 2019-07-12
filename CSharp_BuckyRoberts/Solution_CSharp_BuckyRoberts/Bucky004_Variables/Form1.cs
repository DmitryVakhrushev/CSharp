using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bucky004_Variables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string name = "Adam";
            MessageBox.Show(name);

            int number = 5;
            MessageBox.Show(number.ToString());

            bool isRedHair = false;
            MessageBox.Show(isRedHair.ToString());

            // object variable can be anythig
            object myObj = true;
            MessageBox.Show(myObj.ToString());
        }
    }
}
