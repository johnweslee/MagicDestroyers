using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Armors.Heavy
{
    public class Chainlink
    {
        private const int DEFAULT_ARMOR_POINTS = 100;

        private int armorPoints;

        public int Armorpoints
        {
            get
            {
                return armorPoints;
            }
            set
            {
                if(value >= 1)
                {
                    armorPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Armor points value should be a positive number");
                }
            }
        }

        public Chainlink() : this(DEFAULT_ARMOR_POINTS)
        {

        }

        public Chainlink(int armorPoints)
        {
            this.armorPoints = armorPoints;
        }
    }
}
