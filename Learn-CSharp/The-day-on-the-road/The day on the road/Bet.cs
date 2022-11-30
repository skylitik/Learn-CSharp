using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_day_on_the_road
{
    public class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor = new Guy();

        public string GetDescription()
        {          
              
            if (Amount > 0 )
            {
                return Bettor.Name + " set " + Amount + " on dog number " + Dog;
            }
            else
            {
                return Bettor.Name + "didn't bet";
            }

        }
        public int PayOut(int Winner)
        {
            if (Winner == Dog)
            {
                return Amount;
            }
            else
            {
                return -Amount;
            }
        }
    }
}
