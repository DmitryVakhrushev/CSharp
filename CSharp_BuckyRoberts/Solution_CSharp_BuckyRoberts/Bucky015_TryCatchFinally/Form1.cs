using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bucky015_TryCatchFinally
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try //checks if error occurs
            {
                string[] names = new string[2]; //This array has only two elements with indexes 0 and 1.
                string s = names[2]; //We try to access the third element that's not exist
            }

            catch (Exception ex) //executes on error only
            {
                MessageBox.Show("There was an error: " + ex.Message);
            }

            finally //executes regardless of the error
            {
                MessageBox.Show("Your code is done");
            }
        }
    }
}
