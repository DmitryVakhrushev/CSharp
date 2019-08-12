using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MyNamespace;

namespace Bucky027_Indexers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MyClass mc = new MyClass();
            MessageBox.Show(mc[0]);

            mc[1] = "Bryan"; //set a new value for the second array element
            MessageBox.Show(mc[1]);
        }
    }
}
