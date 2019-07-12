using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AddTableControls
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void t2BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t2BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.buckyDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'buckyDataSet.t2' table. You can move, or remove it, as needed.
            this.t2TableAdapter.Fill(this.buckyDataSet.t2);

        }
    }
}
