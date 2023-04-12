using MagicDestroyers.Equipment.Armors.Heavy;
using MagicDestroyers.Equipment.Weapons.Blunt;

namespace MagicDestroyers.Characters.Melee
{
    public class Knight : Melee
    {
        private readonly Chainlink DEFAULT_BODY_ARMOR = new Chainlink();
        private readonly Hammer DEFAULT_WEAPON = new Hammer();

        public Knight() : this(Constants.Knight.DEFAULT_NAME, Constants.Knight.DEFAULT_LEVEL)
        {
            
        }

        public Knight(string name, int level) : this(name, level, Constants.Knight.DEFAULT_HEALTH_POINTS)
        {
            
        }

        public Knight(string name, int level, int healthPoints)
        {
            base.AbilityPoints = Constants.Knight.DEFAULT_ABILITY_POINTS;
            base.HealthPoints = healthPoints;
            base.Level = level;
            base.Faction = Constants.Knight.DEFAULT_FACTION;
            base.Name = name;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
            base.ISAlive = true;
            base.Score = 0;
        }

        public int HolyBow()
        {
            return base.Weapon.DamagePoints + 10;
        }

        public int PurifySoul()
        {
            throw new NotImplementedException();
        }

        public int RighteousWings()
        {
            return base.BodyArmor.ArmorPoints + 15;
        }

        public override int Attack()
        {
            return this.HolyBow();
        }

        public override int Defend()
        {
            return this.RighteousWings();
        }

        public override int SpecialAttack()
        {
            return this.PurifySoul();
        }
    }
}
