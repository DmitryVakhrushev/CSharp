using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1_Baseball___with_callback
{
    public class Bat
    {
        private BatCallback hitBallCallback;
        public Bat(BatCallback callbackDelegate)
        {
            this.hitBallCallback = new BatCallback(callbackDelegate);
        }

        public void HitTheBall(BallEventArgs e)
        {
            if (hitBallCallback != null)
               hitBallCallback(e);
        }
    }
}