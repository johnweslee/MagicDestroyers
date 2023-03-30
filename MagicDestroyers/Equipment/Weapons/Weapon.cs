using MagicDestroyers.Equipment.Interfaces;

namespace MagicDestroyers.Equipment.Weapons
{
    public abstract class Weapon : IBuff
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
                if (value >= 1)
                {
                    damagePoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Damage points value should be a positive number.");
                }
            }
        }

        public abstract void Buff();
    }
}
