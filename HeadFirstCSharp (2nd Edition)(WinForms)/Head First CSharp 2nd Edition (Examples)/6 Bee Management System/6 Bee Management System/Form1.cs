﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace __Bee_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Nectar collector", "Honey manufacturing" });
            workers[1] = new Worker(new string[] { "Egg care", "Baby bee tutoring" });
            workers[2] = new Worker(new string[] { "Hive maintenance", "Sting patrol" });
            workers[3] = new Worker(new string[] { "Nectar collector", "Honey manufacturing",
                         "Egg care", "Baby bee tutoring", "Hive maintenance", "Sting patrol" });
            queen = new Queen(workers);
        }

        Queen queen;

        private void assignJob_Click(object sender, EventArgs e) {
            if (queen.AssignWork(workerBeeJob.Text, (int)shifts.Value) == false)
                MessageBox.Show("No workers are available to do the job '"
                    + workerBeeJob.Text + "'", "The queen bee says...");
            else
                MessageBox.Show("The job '" + workerBeeJob.Text + "' will be done in "
                    + shifts.Value + " shifts", "The queen bee says...");
        }

        private void nextShift_Click(object sender, EventArgs e) {
            report.Text = queen.WorkTheNextShift();
        }
    }
}
