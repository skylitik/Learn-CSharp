using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przyjecie
{
    class BirthdayParty
    {
        public const int CostOfFoodPerPerson = 25;
        private int numberOfPeople;
        public decimal CostOfDecorations = 0;
        private bool fancyDecorations;

        private string cakeWriting = "";

        public int CakeSize;

        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string CakeWriting) {
            this.numberOfPeople = numberOfPeople;
            this.fancyDecorations = fancyDecorations;
            //this.CakeWriting = CakeWriting;

        }

        public string CakeWriting {  get { return this.cakeWriting; } set {
                int maxLenght;
                if (CakeSize == 20) 
                    maxLenght = 16;
                else
                    maxLenght = 40;
                cakeWriting = value; } }
    }
}
