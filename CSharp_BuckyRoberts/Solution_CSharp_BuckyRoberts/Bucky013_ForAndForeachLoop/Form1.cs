using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bucky013_ForAndForeachLoop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //"For" Loop
            for (int i=0; i < 5; i++)
            {
                MessageBox.Show("Hello" + i.ToString());
            }

            //"ForEach" Loop allows you to loop through every element inside of an array or list

            //Loop through the array
            string[] names = { "Adam", "Bob", "Joe" };
            foreach (string s in names)
            {
                MessageBox.Show("Hello " + s);
            }

            //Loop through the list
            List<int> numbers = new List<int>();
            numbers.Add(5);
            numbers.Add(10);
            numbers.Add(15);

            foreach (int i in numbers)
            {
                MessageBox.Show("The list number = " + i.ToString());
            }


        }
    }
}
