using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//------ Include Created Workspaces ---------
using MyNamespace;
using MyNamespace.MySubNameSpace;

namespace Bucky019_NamespacesAndClasses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("MsgBox");
        }
    }
}
