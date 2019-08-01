using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bucky016_MethodsPart1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Message(); //Call the method "Message" from the Button1
            MessageWithString("Adam");
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            MessageMultiParam("Hi Bob!","Grettings");
        }

        //----------------- My Methods -------------------
        //Method #1
        void Message()
        {
            MessageBox.Show("Hello");
        }

        //Method #2
        void MessageWithString(string message)
        {
            MessageBox.Show(message);
        }

        //Method #3
        void MessageMultiParam(string message, string myTitle)
        {
            MessageBox.Show(message, myTitle);
        }

    }
}
