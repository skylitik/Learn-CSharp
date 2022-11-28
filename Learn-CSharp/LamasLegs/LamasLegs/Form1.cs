using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LamasLegs
{
    public partial class Form1 : Form
    {
        Lama lucinda;
        Lama lloyd;
       
        public Form1()
        {
            InitializeComponent();
            lucinda = new Lama() { Name = "Lucinda", LegSize = 33 };
            lloyd = new Lama() { Name = "Lloyd", LegSize = 45 };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lloyd.WhoAmI();
            Lama[] lamy = new Lama[7];

            lamy[0] = new Lama() { Name = "Lloyd", LegSize = 40 };
            lamy[1] = new Lama() { Name = "Lucinda", LegSize = 33 };
            lamy[2] = new Lama() { Name = "Larry", LegSize = 42 };
            lamy[3] = new Lama() { Name = "Lucille", LegSize = 32 };
            lamy[4] = new Lama() { Name = "Lars", LegSize = 44 };
            lamy[5] = new Lama() { Name = "Linda", LegSize = 37 };
            lamy[6] = new Lama() { Name = "Humpney", LegSize = 45 };

            Lama biggestLegs = lamy[0];
            for (int i = 1; i < lamy.Length; i++)
            {
                if (lamy[i].LegSize > biggestLegs.LegSize)
                {
                    biggestLegs = lamy[i];
                }
            }
            MessageBox.Show(biggestLegs.LegSize.ToString());

        }
        private void button2_Click(object sender, EventArgs e)
        {
            lucinda.WhoAmI();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lama reverse;
            reverse = lucinda;
            lucinda = lloyd;
            lloyd = reverse;
            MessageBox.Show("Obiekty zamienione");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            Lama lloyd = new Lama() { Name = "Lloyd", LegSize = 40 };
            Lama lucinda = new Lama() { Name = "Lucinda", LegSize = 33 };
            
           // lloyd.TellMe("Cześć", lucinda);
            //lloyd = lucinda;
            //lloyd.LegSize = 4321;
            lucinda.SpeakTo(lloyd, "Witaj");
            //lloyd.WhoAmI();
        }
    }
}
