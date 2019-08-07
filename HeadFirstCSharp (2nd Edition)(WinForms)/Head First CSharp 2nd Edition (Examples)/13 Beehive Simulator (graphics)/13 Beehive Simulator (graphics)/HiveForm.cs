using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _3_Beehive_Simulator__graphics_
{
    public partial class HiveForm : Form
    {
        public HiveForm()
        {
            InitializeComponent();
            BackgroundImage = Renderer.ResizeImage(
                    Properties.Resources.Hive__inside_,
                    ClientRectangle.Width, ClientRectangle.Height);
        }

        public Renderer renderer;
        private void HiveForm_Paint(object sender, PaintEventArgs e)
        {
            renderer.PaintHive(e.Graphics);
        }
    }
}
