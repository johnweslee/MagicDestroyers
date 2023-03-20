using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Weapons.Blunt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Druid
    {
        private int abilityPoints;
        private int healthPoints;
        private int level;

        private string faction;
        private string name;

        private LeatherLightVest bodyArmor;
        private Staff weapon;

        public int AbilityPoints
        {
            get
            {
                return abilityPoints;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    abilityPoints = value;
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
                return healthPoints;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    healthPoints = value;
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
                return level;
            }
            set
            {
                if (value >= 0)
                {
                    level = value;
                }
            }
        }

        public string Faction
        {
            get
            {
                return faction;
            }
            set
            {
                if (value == "Melee" || value == "SpellCasters")
                {
                    faction = value;
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
                return name;
            }
            set
            {
                if (value.Length >= 3 && value.Length <= 16)
                {
                    name = value;
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
                return bodyArmor;
            }
            set
            {
                bodyArmor = value;
            }
        }

        public Staff Weapon
        {
            get
            {
                return weapon;
            }
            set
            {
                weapon = value;
            }
        }

        public Druid()
        {

        }

        public void MoonFire()
        {
            throw new NotImplementedException();
        }

        public void Starburst()
        {
            throw new NotImplementedException();
        }

        public void OneWithTheNature()
        {
            throw new NotImplementedException();
        }
    }
}
