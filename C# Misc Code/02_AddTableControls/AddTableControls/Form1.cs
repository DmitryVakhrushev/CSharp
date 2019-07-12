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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void t1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.buckyDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'buckyDataSet.t2' table. You can move, or remove it, as needed.
            this.t2TableAdapter.Fill(this.buckyDataSet.t2);
            // TODO: This line of code loads data into the 'buckyDataSet.t1' table. You can move, or remove it, as needed.
            this.t1TableAdapter.Fill(this.buckyDataSet.t1);
            // TODO: This line of code loads data into the 'buckyDataSet.t2' table. You can move, or remove it, as needed.
            this.t2TableAdapter.Fill(this.buckyDataSet.t2);
            // TODO: This line of code loads data into the 'buckyDataSet.t1' table. You can move, or remove it, as needed.
            this.t1TableAdapter.Fill(this.buckyDataSet.t1);

        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void t1BindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.t1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.buckyDataSet);

        }
    }
}
