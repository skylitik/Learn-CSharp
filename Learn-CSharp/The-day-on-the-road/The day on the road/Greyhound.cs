using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace The_day_on_the_road
{
    public class Greyhound
    {
        public int StartPosition;
        public int RacetrackLength;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random MyRandom;

        public bool Run()
        {                  
            Location += MyRandom.Next(1, 68);
            MyPictureBox.Left = StartPosition + Location;
            if (Location >= RacetrackLength)
            {
                return true;
            }
            return false;

        }

        public void TakeStartPosition() 
        {
            Location = 0;
            MyPictureBox.Left = StartPosition;
        }
    }
}
