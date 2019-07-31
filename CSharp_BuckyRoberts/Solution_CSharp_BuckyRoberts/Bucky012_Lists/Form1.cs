using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bucky012_Lists
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //ARRAY
            string[] myArray = new string[4]; //array requires the 

            //LIST
            //List of strings
            List<string> Names = new List<string>(); //list
            Names.Add("Adam");
            Names.Add("Joe");
            MessageBox.Show(Names[0]); //access the first element of the list

            //List of integers
            List<int> numbers = new List<int>();
            numbers.Add(5);
            numbers.Add(598);
            MessageBox.Show(numbers[1].ToString());
        }
    }
}
