using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _3_Zoomer
{
    public partial class Zoomer : UserControl
    {
        Bitmap photo = new Bitmap(@"c:\Graphics\fluffy_dog.jpg");

        public Zoomer()
        {
            InitializeComponent();
        }

        private void Zoomer_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.White, 0, 0, Width, Height);
            g.DrawImage(photo, 10, 10, trackBar1.Value, trackBar2.Value);
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Invalidate();
        }
    }

}