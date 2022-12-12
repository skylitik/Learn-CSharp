﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmer
{
    public partial class Form1 : Form
    {
        Farmer farmer;
        public Form1()
        {
            InitializeComponent();
            farmer = new Farmer() { NumbersOfCows = 15 };
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            farmer.NumbersOfCows = (int)numericUpDown1.Value;
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Potrzebuje {0} worków paszy do wykarmienia {1} krów", farmer.BagsOfFeed, farmer.NumbersOfCows);
        }

        private void instrukcja_Click(object sender, EventArgs e)
        {
            
        }
    }
}