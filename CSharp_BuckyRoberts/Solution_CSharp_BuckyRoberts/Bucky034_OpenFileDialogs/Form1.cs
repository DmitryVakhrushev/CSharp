using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bucky034_OpenFileDialogs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            //Add title to the dialog box (top left)
            ofd.Title = "Open Image";
            
            //limit file selection
            ofd.Filter = "PNG Image|*.png|BIK|*.bik";

            //If a user selects a file and clicks "open" we will see a message box
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show(ofd.FileName); // full patch with the file name
                MessageBox.Show(ofd.SafeFileName); //file name only
            }
        }
    }
}
