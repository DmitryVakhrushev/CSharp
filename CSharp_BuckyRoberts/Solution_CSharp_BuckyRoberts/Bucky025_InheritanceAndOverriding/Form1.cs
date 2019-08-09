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

namespace Bucky025_InheritanceAndOverriding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MySecondClass msc = new MySecondClass();
            msc.MessageBoxSpecial();
            msc.MessageBoxSpecial2();
            msc.ShowMessage("Hello");
            msc.VirtShowMsg("Another Hello");

        }
    }
}
