using MagicDestroyers.Enumerations;
using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Weapons.Sharp;
using System;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Necromancer : Spellcaster
    {
        private const int DEFAULT_ABILITY_POINTS = 100;
        private const int DEFAULT_HEALTH_POINTS = 100;
        private const int DEFAULT_LEVEL = 0;

        private const Faction DEFAULT_FACTION = Faction.SpellCasters;
        private const string DEFAULT_NAME = "Necromancer";

        private readonly LeatherLightVest DEFAULT_BODY_ARMOR = new LeatherLightVest();
        private readonly Sword DEFAULT_WEAPON = new Sword();

        private LeatherLightVest bodyArmor;
        private Sword weapon;

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

        public Necromancer() : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
            
        }

        public Necromancer(string name, int level) : this(name, level, DEFAULT_HEALTH_POINTS)
        {
            
        }

        public Necromancer(string name, int level, int healthPoints)
        {
            this.ManaPoints = DEFAULT_ABILITY_POINTS;
            this.HealthPoints = healthPoints;
            this.Level = level;
            this.Faction = DEFAULT_FACTION;
            this.Name = name;
            this.BodyArmor = DEFAULT_BODY_ARMOR;
            this.Weapon = DEFAULT_WEAPON;
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
