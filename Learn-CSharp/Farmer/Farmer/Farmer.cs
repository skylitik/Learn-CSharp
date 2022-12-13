using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmer
{
    public class Farmer
    {
        public int BagsOfFeed { get; private set; }
        private int feedMultiplier;
        public int FeedMultiplier { get { return feedMultiplier; } }
        public Farmer(int numbersOfCows, int feedMultiplier)
        {
            this.feedMultiplier = feedMultiplier;
            NumbersOfCows = numbersOfCows;
        }

        private int numberOfCows;
        public int NumbersOfCows
        {
            get { return numberOfCows; }
            set { numberOfCows = value;
                  BagsOfFeed = numberOfCows * FeedMultiplier;
                }
        }
        
    }
}
