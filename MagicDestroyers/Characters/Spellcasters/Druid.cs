using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Weapons.Blunt;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Druid : Spellcaster
    {
        private readonly LeatherLightVest DEFAULT_BODY_ARMOR = new LeatherLightVest();
        private readonly Staff DEFAULT_WEAPON = new Staff();

        public Druid() : this(Constants.Druid.DEFAULT_NAME, Constants.Druid.DEFAULT_LEVEL)
        {
            
        }

        public Druid(string name, int level) : this(name, level, Constants.Druid.DEFAULT_HEALTH_POINTS)
        {
            
        }

        public Druid(string name, int level, int healthPoints)
        {
            base.ManaPoints = Constants.Druid.DEFAULT_MANA_POINTS;
            base.HealthPoints = healthPoints;
            base.Level = level;
            base.Faction = Constants.Druid.DEFAULT_FACTION;
            base.Name = name;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
            base.ISAlive = true;
            base.Score = 0;
        }

        public int MoonFire()
        {
            return base.Weapon.DamagePoints + 5;
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
