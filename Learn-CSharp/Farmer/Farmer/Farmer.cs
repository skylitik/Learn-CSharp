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
        public const int FeedMultiplier = 30;

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
