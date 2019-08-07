using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1_Baseball
{
    public class Ball
    {
        public event EventHandler BallInPlay;
        public void OnBallInPlay(BallEventArgs e)
        {
            if (BallInPlay != null)
                BallInPlay(this, e);
        }
    }
}
