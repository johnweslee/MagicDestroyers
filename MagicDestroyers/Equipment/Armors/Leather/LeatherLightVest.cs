using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Armors.Leather
{
    public class LeatherLightVest : Leather
    {
        private const int DEFAULT_ARMOR_POINTS = 100;

        public LeatherLightVest() : this(DEFAULT_ARMOR_POINTS)
        {

        }

        public LeatherLightVest(int armorPoints)
        {
            this.ArmorPoints = armorPoints; 
        }

        public override void Buff()
        {
            throw new NotImplementedException();
        }
    }
}
