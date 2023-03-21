using MagicDestroyers.Equipment.Armors.Heavy;
using MagicDestroyers.Equipment.Weapons.Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Characters.Melee
{
    public class Warrior
    {
        private int abilityPoints;
        private int healthPoints;
        private int level;

        private string faction;
        private string name;

        private Chainlink bodyArmor;
        private Axe weapon;

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
            get {
                return this.bodyArmor;
            }
            set
            {
                this.bodyArmor = value;
            } 
        }

        public Axe Weapon
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

        public Warrior()
        {
            this.AbilityPoints = 100;
            this.HealthPoints = 100;
            this.Level = 100;
            this.Faction = "Melee";
            this.Name = "Warrior";
            this.BodyArmor = new Chainlink();
            this.Weapon = new Axe();
        }

        public Warrior(string name, int level)
        {
            this.AbilityPoints = 100;
            this.HealthPoints = 100;
            this.Level = level;
            this.Faction = "Melee";
            this.Name = name;
            this.BodyArmor = new Chainlink();
            this.Weapon = new Axe();
        }

        public Warrior(string name, int level, int healthPoints)
        {
            this.AbilityPoints = 100;
            this.HealthPoints = healthPoints;
            this.Level = level;
            this.Faction = "Melee";
            this.Name = name;
            this.BodyArmor = new Chainlink();
            this.Weapon = new Axe();
        }

        public void Strike()
        {
            throw new NotImplementedException();
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }

        public void SkinHarden()
        {
            throw new NotImplementedException();
        }
    }
}
