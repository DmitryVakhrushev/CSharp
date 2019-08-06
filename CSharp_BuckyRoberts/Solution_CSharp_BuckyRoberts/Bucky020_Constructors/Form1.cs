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

namespace Bucky020_Constructors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MyClass mc = new MyClass("Adam");
            //When you create an instance of your class the compiler looks for the CONSTRUCTOR
            //If it's not exist the compiler uses the default constructor

        }
    }
}
