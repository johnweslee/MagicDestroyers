using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Weapons.Sharp;

namespace MagicDestroyers.Characters.Melee
{
    public class Assassin : Melee
    {
        private readonly LeatherLightVest DEFAULT_BODY_ARMOR = new LeatherLightVest();
        private readonly Sword DEFAULT_WEAPON = new Sword();

        public Assassin() : this(Constants.Assassin.DEFAULT_NAME, Constants.Assassin.DEFAULT_LEVEL)
        {
        }

        public Assassin(string name, int level) : this(name, level, Constants.Assassin.DEFAULT_HEALTH_POINTS)
        {
        }

        public Assassin(string name, int level, int healthPoints)
        {
            base.AbilityPoints = Constants.Assassin.DEFAULT_ABILITY_POINTS;
            base.HealthPoints = healthPoints;
            base.Level = level;
            base.Faction = Constants.Assassin.DEFAULT_FACTION;
            base.Name = name;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
            base.ISAlive = true;
            base.Score = 0;
        }

        public int Raze()
        {
            return base.Weapon.DamagePoints + 10;
        }

        public int BleedToDeath()
        {
            throw new NotImplementedException();
        }

        public int Survival ()
        {
            return base.BodyArmor.ArmorPoints + 10;
        }

        public override int Attack()
        {
            return this.Raze();
        }

        public override int Defend()
        {
            return this.Survival();
        }

        public override int SpecialAttack()
        {
            return this.BleedToDeath();
        }
    }
}
