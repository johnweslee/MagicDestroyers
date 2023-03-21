using MagicDestroyers.Equipment.Armors.Heavy;
using MagicDestroyers.Equipment.Weapons.Blunt;
using System;

namespace MagicDestroyers.Characters.Melee
{
    public class Knight
    {
        private const int DEFAULT_ABILITY_POINTS = 100;
        private const int DEFAULT_HEALTH_POINTS = 100;
        private const int DEFAULT_LEVEL = 0;

        private const string DEFAULT_FACTION = "Melee";
        private const string DEFAULT_NAME = "Knight";

        private readonly Chainlink DEFAULT_BODY_ARMOR = new Chainlink();
        private readonly Hammer DEFAULT_WEAPON = new Hammer();

        private int abilityPoints;
        private int healthPoints;
        private int level;

        private string faction;
        private string name;

        private Chainlink bodyArmor;
        private Hammer weapon;

        public int AbilityPoints
        {
            get
            {
                return this.abilityPoints;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    this.abilityPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Invalid ability points! It should be between the range 0 to 100.");
                }
            }
        }

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

        public string Faction
        {
            get
            {
                return this.faction;
            }
            set
            {
                if (value == "Melee" || value == "SpellCasters")
                {
                    this.faction = value;
                }
                else
                {
                    throw new ArgumentException(string.Empty, "Faction should be either Melee or SpellCasters.");
                }
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

        public Chainlink BodyArmor
        {
            get
            {
                return this.bodyArmor;
            }
            set
            {
                this.bodyArmor = value;
            }
        }

        private Hammer Weapon
        {
            get
            {
                return this.weapon;
            }
            set
            {
                this.weapon = value;
            }
        }

        public Knight() : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
            
        }

        public Knight(string name, int level) : this(name, level, DEFAULT_HEALTH_POINTS)
        {
            
        }

        public Knight(string name, int level, int healthPoints)
        {
            this.AbilityPoints = DEFAULT_ABILITY_POINTS;
            this.HealthPoints = healthPoints;
            this.Level = level;
            this.Faction = DEFAULT_FACTION;
            this.Name = name;
            this.BodyArmor = DEFAULT_BODY_ARMOR;
            this.Weapon = DEFAULT_WEAPON;
        }

        public void HolyBow()
        {
            throw new NotImplementedException();
        }

        public void PurifySoul()
        {
            throw new NotImplementedException();
        }

        public void RighteousWings()
        {
            throw new NotImplementedException();
        }
    }
}
