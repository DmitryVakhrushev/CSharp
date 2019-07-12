using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace addingDataToSqlServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* if we didn't import "System.Data.SqlClient"
               we would use the full reference to create a SqlConnection object
               e.g.: System.Data.SqlClient.SqlConnection myConn1;
            */

            SqlConnection cs = new SqlConnection("Data Source=A-DMVAKH-W500\\DIMSQL; Initial Catalog=bucky; Integrated Security=TRUE");

            /*-----------------------
              test the connection
              -----------------------
                cs.Open();
                MessageBox.Show(cs.State.ToString());
                cs.Close();
            */

            // "SqlData Adapter" sends data from the form to the pipe
            SqlDataAdapter da = new SqlDataAdapter();
            da.InsertCommand = new SqlCommand("INSERT INTO tblContacts VALUES(@FIRSTNAME, @LASTNAME)", cs);
            da.InsertCommand.Parameters.Add("@FIRSTNAME", SqlDbType.VarChar).Value = txtFirstName.Text;
            da.InsertCommand.Parameters.Add("@LASTNAME", SqlDbType.VarChar).Value = txtLastName.Text;

            // Open/close connesction and execute the query
            cs.Open();
            da.InsertCommand.ExecuteNonQuery();
            cs.Close();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
