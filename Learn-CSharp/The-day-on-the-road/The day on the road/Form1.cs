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
        Random random = new Random();
        
        public Form1()
        {
            InitializeComponent();            
            dogs[0] = new Greyhound() {MyPictureBox = dog_1, RacetrackLength = fieldbox.Width, StartPosition = dog_1.Width, MyRandom = random};
            dogs[1] = new Greyhound() {MyPictureBox = dog_2, RacetrackLength = fieldbox.Width, StartPosition = dog_2.Width, MyRandom = random }; 
            dogs[2] = new Greyhound() {MyPictureBox = dog_3, RacetrackLength = fieldbox.Width, StartPosition = dog_3.Width , MyRandom = random }; 
            dogs[3] = new Greyhound() {MyPictureBox = dog_4, RacetrackLength = fieldbox.Width, StartPosition = dog_4.Width , MyRandom = random }; 
            
            guys[0] = new Guy() { Name = "John", Cash = 50, MyRadioButton = john_radio, MyLabel = johns_label};
            guys[1] = new Guy() { Name = "Sam", Cash = 75, MyRadioButton = sams_radio, MyLabel = sams_label};
            guys[2] = new Guy() { Name = "Britney", Cash = 100, MyRadioButton = britney_radio, MyLabel = britney_label};

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
            Bet bet = new Bet();
            
            
            for (int i = 0; i < 4; i++)
            {
                while (dogs[i].Run())
                {
                    foreach (var dog in dogs)
                    {
                        if (dog.RacetrackLength >= dog.StartPosition)
                        {
                            dog.RacetrackLength -= dog.StartPosition;

                        }
                        else
                        {
                            dog.TakeStartPosition();

                        }

                    }                   

                }                
                
            }
            
        }
    }
}
