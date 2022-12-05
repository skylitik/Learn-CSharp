using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przyjecie
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        public Form1()
        {         
                            
            InitializeComponent();
            dinnerParty = new DinnerParty() { NumberOfPeople = 5 };
            dinnerParty.SetHealthyOption(checkBox_healthy.Checked);
            dinnerParty.CalculateCostOfDecorations(checkBox_decorations.Checked);
            DisplayDinnerPartyCost();
            

        }
        

       
        private void checkBox_decorations_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.CalculateCostOfDecorations(checkBox_decorations.Checked);
            DisplayDinnerPartyCost();
            
        }

        private void checkBox_healthy_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.SetHealthyOption(checkBox_healthy.Checked);
            DisplayDinnerPartyCost();
        }
        private void numeric_people_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numeric_people.Value;
            //dinnerParty.CalculateCostOfDecorations(checkBox_healthy.Checked) ;
            DisplayDinnerPartyCost();

        }
        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.CalculateCost(checkBox_healthy.Checked);
            label_empty.Text = Cost.ToString("c");
        }
    }
}
