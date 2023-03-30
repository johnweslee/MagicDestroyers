using MagicDestroyers.Equipment.Interfaces;

namespace MagicDestroyers.Equipment.Armors
{
    public  abstract class Armor : IBuff
    {
        private int armorPoints;

        public int ArmorPoints
        {
            get
            {
                return armorPoints;
            }
            set
            {
                if (value >= 1)
                {
                    armorPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Armor points value should be a positive number");
                }
            }
        }

        public abstract void Buff();
    }
}
