﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace __Joe_and_Bob__serialized
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
