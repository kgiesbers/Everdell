using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public abstract class Card
    {
        private string name;
        private enum type
        {
            Production,
            Governance,
            Traveler,
            Prosperity
        }
        private enum rarity
        {
            Common,
            Unique
        }
        private enum Group
        {
            Critter,
            Construction
        }
        private int value;
        private int berryCost;
        private int twigCost;
        private int pebbleCost;
        private int resinCost;
        
    }
}
