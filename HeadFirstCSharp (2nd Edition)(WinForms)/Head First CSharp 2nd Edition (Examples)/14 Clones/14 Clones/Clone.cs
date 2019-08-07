using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _4_Clones
{
    public class Clone : IDisposable
    {
        public int ID { get; private set; }

        public Clone(int ID)
        {
            this.ID = ID;
        }

        public void Dispose()
        {
            MessageBox.Show("I’ve been disposed!", "Clone #" + ID + " says...");
        }

        ~Clone()
        {
            MessageBox.Show("Aaargh! You got me!", "Clone #" + ID + " says...");
        }
    }
}
