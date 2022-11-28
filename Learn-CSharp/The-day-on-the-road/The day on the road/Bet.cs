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
        public Guy Bettor;

        public string GetDescription()
        {          
            
            if (Amount >= 5 && Amount <= 15)
            {
                return Bettor.Name + " Bet " + Amount + " usd on dog number " + Dog;
            }
            else
            {
                return this.Bettor.Name + " didn't bet";  
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
