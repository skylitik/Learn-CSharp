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
            int distance = 0;
            distance = MyRandom.Next(1,4);
            Point p = MyPictureBox.Location;
            p.X += distance;
            MyPictureBox.Location = p;
            return true;

        }

        public void TakeStartPosition() 
        {
            StartPosition = 0;

        }
    }
}
