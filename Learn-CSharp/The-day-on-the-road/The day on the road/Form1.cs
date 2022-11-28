using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_day_on_the_road
{
    public partial class Form1 : Form
    {
        Greyhound[] dogs = new Greyhound[4];
        Guy[] guys = new Guy[3];
        public Form1()
        {
            InitializeComponent();            
            dogs[0] = new Greyhound() {MyPictureBox = this.dog_1, StartPosition = dog_1.Location.X, RacetrackLength = fieldbox.Width };
            dogs[1] = new Greyhound() {MyPictureBox = this.dog_2, StartPosition = dog_2.Location.X, RacetrackLength = fieldbox.Width }; 
            dogs[2] = new Greyhound() {MyPictureBox = this.dog_3, StartPosition = dog_3.Location.X, RacetrackLength = fieldbox.Width }; 
            dogs[3] = new Greyhound() {MyPictureBox = this.dog_4, StartPosition = dog_4.Location.X, RacetrackLength = fieldbox.Width }; 
            
            guys[0] = new Guy() { Name = "John", Cash = 50, MyRadioButton = john_radio, MyLabel = johns_label, MyBet = new Bet()};
            guys[1] = new Guy() { Name = "Sam", Cash = 75, MyRadioButton = sams_radio, MyLabel = sams_label, MyBet = new Bet()};
            guys[2] = new Guy() { Name = "Britney", Cash = 100, MyRadioButton = britney_radio, MyLabel = britney_label, MyBet = new Bet()};
            foreach (var guy in guys)
            {
                guy.UpdateLabels();
            }
            
        }

        private void john_radio_CheckedChanged(object sender, EventArgs e)
        {
            
            
            name_bet_label.Text = guys[0].Name;
            guys[0].UpdateLabels();
            
            
            

        }

        private void sams_radio_CheckedChanged(object sender, EventArgs e)
        {
            name_bet_label.Text = guys[1].Name;
            guys[1].UpdateLabels();
            

        }

        private void britney_radio_CheckedChanged(object sender, EventArgs e)
        {
            name_bet_label.Text = guys[2].Name;
           
            guys[2].UpdateLabels();
        }

        

        private void bet_button_Click(object sender, EventArgs e)
        {
            

            bet_min.Text = bet_value.Value.ToString();
            foreach (var guy in guys)
            {
                if (guy.MyRadioButton.Checked)
                {
                    if (guy.PlaceBet((int)bet_value.Value, (int)dog_updown.Value))
                    {
                        guy.UpdateLabels();
                    } 
                }
            }
            



        }

        private void start_button_Click(object sender, EventArgs e)
        {

        }
    }
}
