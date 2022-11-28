using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_trip
{
    public partial class Form1 : Form
    {
        int startingMieleage;
        int endingMieleage;
        double milesTraveled;
        double reimburseRate;
        double amountOwed;

        public Form1()
        {
           
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startingMieleage = (int)numericUpDown1.Value;
            endingMieleage = (int)numericUpDown2.Value;
            reimburseRate = (double)numericUpDown3.Value;
            if (startingMieleage > endingMieleage)
            {
                MessageBox.Show("The value of the ending point can't be less then starting point of the meter", "Can't calculate average");
            }
            else
            {
                milesTraveled = endingMieleage -= startingMieleage;
                amountOwed = milesTraveled *= reimburseRate;
                label4.Text = amountOwed.ToString() + " usd";
            }
        }
    }
}
