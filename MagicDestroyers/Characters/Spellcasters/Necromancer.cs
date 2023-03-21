using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Armors.Light;
using MagicDestroyers.Equipment.Weapons.Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Necromancer
    {
        private int abilityPoints;
        private int healthPoints;
        private int level;

        private string faction;
        private string name;

        private LeatherLightVest bodyArmor;
        private Sword weapon;

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

        public LeatherLightVest BodyArmor
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

        public Sword Weapon
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

        public Necromancer()
        {
            this.AbilityPoints = 100;
            this.HealthPoints = 100;
            this.Level = 100;
            this.Faction = "SpellCasters";
            this.Name = "Necromancer";
            this.BodyArmor = new LeatherLightVest();
            this.Weapon = new Sword();
        }

        public Necromancer(string name, int level)
        {
            this.AbilityPoints = 100;
            this.HealthPoints = 100;
            this.Level = level;
            this.Faction = "SpellCasters";
            this.Name = name;
            this.BodyArmor = new LeatherLightVest();
            this.Weapon = new Sword();
        }

        public Necromancer(string name, int level, int healthPoints)
        {
            this.AbilityPoints = 100;
            this.HealthPoints = healthPoints;
            this.Level = level;
            this.Faction = "SpellCasters";
            this.Name = name;
            this.BodyArmor = new LeatherLightVest();
            this.Weapon = new Sword();
        }

        public void ShadowRage()
        {
            throw new NotImplementedException();
        }

        public void VampireTouch()
        {
            throw new NotImplementedException();
        }

        public void BoneShiled()
        {
            throw new NotImplementedException();
        }
    }
}
