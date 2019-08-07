using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace __Cow_Calculator
{
    class Farmer
    {
        public int BagsOfFeed { get; private set; }

        public int FeedMultiplier { get; private set; }

        private int numberOfCows;
        public int NumberOfCows
        {
            get
            {
                return numberOfCows;
            }
            set
            {
                numberOfCows = value;
                BagsOfFeed = numberOfCows * FeedMultiplier;
            }
        }

        public Farmer(int numberOfCows, int feedMultiplier)
        {
            FeedMultiplier = feedMultiplier; // set this first
            this.NumberOfCows = numberOfCows;
        }
    }
}
