using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Weapons.Blunt
{
    public class Staff
    {
        private int damagePoints;

        public int DamagePoints
        {
            get
            {
                return damagePoints;
            }
            set
            {
                if(value >= 1)
                {
                    damagePoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Damage points value should be a positive number.");
                }
            }
        }

        public Staff()
        {

        }

        public void Empower()
        {
            throw new NotImplementedException();
        }
    }
}
