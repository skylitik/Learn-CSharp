using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przyjecie
{
    public class DinnerParty
    { 
        public const int CostOfFoodPerPerson = 25;
        private int numberOfPeople;
        private bool fancyDecorations;
        public int NumberOfPeople
        {
            get {return numberOfPeople; }
            set {
                numberOfPeople = value;
                CalculateCostOfDecorations(fancyDecorations); } 
        }
        
        
        decimal CostOfBeveragesPerPerson;
        decimal CostOfDecorations = 0;
        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations) {
            NumberOfPeople = numberOfPeople;
            this.fancyDecorations = fancyDecorations;
            SetHealthyOption(healthyOption);            
            CalculateCostOfDecorations(fancyDecorations);
        }

        public void SetHealthyOption(bool healthyOption)
        {
            if (healthyOption)
            {
                CostOfBeveragesPerPerson = 5.00M;
            }
            else
            {
                CostOfBeveragesPerPerson = 20.00M;
            }
        }
        public void CalculateCostOfDecorations(bool fancy)
        {
            fancyDecorations = fancy;
            if (fancy)
            {
                CostOfDecorations = (15.00M * NumberOfPeople) + 50M;
            }
            else
            {
                CostOfDecorations = (7.50M * NumberOfPeople) + 30M;
            }
             
        }       
        public decimal CalculateCost(bool healthyOption)
        {
            decimal totalCost = CostOfDecorations + ((CostOfBeveragesPerPerson + CostOfFoodPerPerson) * NumberOfPeople);
            if (healthyOption)
            {
                return totalCost = totalCost / 1.05M;
            }
            else
            {
                return totalCost;
            }
        }
       
    }
}
