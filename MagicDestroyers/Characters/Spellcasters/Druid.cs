using MagicDestroyers.Enumerations;
using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Weapons.Blunt;
using System;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Druid : Spellcaster
    {
        private const int DEFAULT_ABILITY_POINTS = 100;
        private const int DEFAULT_HEALTH_POINTS = 100;
        private const int DEFAULT_LEVEL = 0;

        private const Faction DEFAULT_FACTION = Faction.SpellCasters;
        private const string DEFAULT_NAME = "Druid";

        private readonly LeatherLightVest DEFAULT_BODY_ARMOR = new LeatherLightVest();
        private readonly Staff DEFAULT_WEAPON = new Staff();
        
        private LeatherLightVest bodyArmor;
        private Staff weapon;

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

        public Staff Weapon
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

        public Druid() : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
            
        }

        public Druid(string name, int level) : this(name, level, DEFAULT_HEALTH_POINTS)
        {
            
        }

        public Druid(string name, int level, int healthPoints)
        {
            this.ManaPoints = DEFAULT_ABILITY_POINTS;
            this.HealthPoints = healthPoints;
            this.Level = level;
            this.Faction = DEFAULT_FACTION;
            this.Name = name;
            this.BodyArmor = DEFAULT_BODY_ARMOR;
            this.Weapon = DEFAULT_WEAPON;
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
