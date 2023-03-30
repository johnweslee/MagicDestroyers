using MagicDestroyers.Characters.Interfaces;
using MagicDestroyers.Enumerations;

namespace MagicDestroyers.Characters
{
    public abstract class Character : IAttack, IDefend
    {
        private int healthPoints;
        private int level;

        private Faction faction;
        private string name;

        public int HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    this.healthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Invalid health points! It should be between the range 0 to 100.");
                }
            }
        }

        public int Level
        {
            get
            {
                return this.level;
            }
            set
            {
                if (value >= 0)
                {
                    this.level = value;
                }
            }
        }

        public Faction Faction
        {
            get
            {
                return this.faction;
            }
            set
            {
                this.faction = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length >= 3 && value.Length <= 16)
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException(string.Empty, "Invalid name! The length of the name shoulde be between 3 to 16 characters.");
                }
            }
        }

        public abstract void Attack();
        public abstract void Defend();
        public abstract void SpecialAttack();
    }
}
