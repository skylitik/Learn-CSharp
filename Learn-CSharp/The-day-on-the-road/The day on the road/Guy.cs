using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_day_on_the_road
{
    public class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;

        public RadioButton MyRadioButton;
        public Label MyLabel;

       

        public void UpdateLabels()
        {            
            
            MyRadioButton.Text =  Name + " has " + Cash;
            MyLabel.Text = MyBet.GetDescription();

        }
        public void ClearBet()
        {
          MyBet.Amount = 0;          
        }
        public bool PlaceBet(int Amount, int Dog)
        {
            
            if (Cash >= 5)
            {
                MyBet.Amount = Amount;
                MyBet.Dog = Dog;
                return true;
            }
            else
            {
                MessageBox.Show("You have no enough cash");
                return false;
            }
            
        }
        public void Collect(int Winner)
        {
            MyBet.PayOut(Winner);
        }
    }
}
