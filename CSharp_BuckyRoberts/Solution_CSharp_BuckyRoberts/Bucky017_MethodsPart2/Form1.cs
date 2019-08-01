using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bucky017_MethodsPart2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MyMethod2() + " " + MyMethod("Adam") + " " + MyMethod3().ToString());
        }
        
        //==================== My Methods ====================
        /* Return type
         * void - returns nothing
         * string - returns a specified string
        */
        string MyMethod(string name)
        {
            return name;
        }

        //MyMethod2 returns a static STRING value
        string MyMethod2()
        {
            return "Hello";
        }

        //MyMethod3 returns a static INT value
        int MyMethod3()
        {
            return 27;
        }

    }
}
