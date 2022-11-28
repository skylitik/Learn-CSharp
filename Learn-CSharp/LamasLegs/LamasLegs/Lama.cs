using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LamasLegs
{
    public class Lama
    {
        public int LegSize;
        public string Name;
        public void WhoAmI()
        {
            MessageBox.Show("Moje kopytka mają " + LegSize + " centymetrów długosci.", Name + " mówi");
        }

        public void TellMe(string message, Lama whoSaidIt)
        {
            MessageBox.Show(whoSaidIt.Name + " mówi:" + message);
        }

        public void SpeakTo(Lama talkTo, string message)
        {
            talkTo.TellMe(message, this);
        }
    }

}