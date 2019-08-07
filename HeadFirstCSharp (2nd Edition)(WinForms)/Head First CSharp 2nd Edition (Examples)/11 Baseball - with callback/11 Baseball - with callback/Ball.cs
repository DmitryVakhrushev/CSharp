using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1_Baseball___with_callback
{
    public class Ball
    {
        public Bat GetNewBat()
        {
            return new Bat(new BatCallback(OnBallInPlay));
        }

        public event EventHandler BallInPlay;

        protected void OnBallInPlay(BallEventArgs e)
        {
            if (BallInPlay != null)
                BallInPlay(this, e);
        }
    }
}
