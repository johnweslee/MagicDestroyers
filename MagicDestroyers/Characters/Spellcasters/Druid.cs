using MagicDestroyers.Enumerations;
using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Weapons.Blunt;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Druid : Spellcaster
    {
        private const int DEFAULT_MANA_POINTS = 100;
        private const int DEFAULT_HEALTH_POINTS = 100;
        private const int DEFAULT_LEVEL = 0;

        private const Faction DEFAULT_FACTION = Faction.SpellCasters;
        private const string DEFAULT_NAME = "Druid";

        private readonly LeatherLightVest DEFAULT_BODY_ARMOR = new LeatherLightVest();
        private readonly Staff DEFAULT_WEAPON = new Staff();

        public Druid() : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
            
        }

        public Druid(string name, int level) : this(name, level, DEFAULT_HEALTH_POINTS)
        {
            
        }

        public Druid(string name, int level, int healthPoints)
        {
            base.ManaPoints = DEFAULT_MANA_POINTS;
            base.HealthPoints = healthPoints;
            base.Level = level;
            base.Faction = DEFAULT_FACTION;
            base.Name = name;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
            base.ISAlive = true;
            base.Score = 0;
        }

        public int MoonFire()
        {
            return base.Weapon.DamagePoints + 10;
        }

        public int Starburst()
        {
            throw new NotImplementedException();
        }

        public int OneWithTheNature()
        {
            return base.BodyArmor.ArmorPoints + 5;
        }

        public override int Attack()
        {
            return this.MoonFire();
        }

        public override int Defend()
        {
            return this.OneWithTheNature();
        }

        public override int SpecialAttack()
        {
            return this.Starburst();
        }
    }
}
