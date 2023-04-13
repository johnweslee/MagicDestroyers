using MagicDestroyers.Equipment.Armors.Heavy;
using MagicDestroyers.Equipment.Weapons.Sharp;

namespace MagicDestroyers.Characters.Melee
{
    public class Warrior : Melee
    {
        private readonly Chainlink DEFAULT_BODY_ARMOR = new Chainlink();
        private readonly Axe DEFAULT_WEAPON = new Axe();

        public Warrior() : this(Constants.Warrior.DEFAULT_NAME, Constants.Warrior.DEFAULT_LEVEL)
        {
            
        }

        public Warrior(string name, int level) : this(name, level, Constants.Warrior.DEFAULT_HEALTH_POINTS)
        {
            
        }

        public Warrior(string name, int level, int healthPoints)
        {
            base.AbilityPoints = Constants.Warrior.DEFAULT_ABILITY_POINTS;
            base.HealthPoints = healthPoints;
            base.Level = level;
            base.Faction = Constants.Warrior.DEFAULT_FACTION;
            base.Name = name;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
            base.ISAlive = true;
            base.Score = 0;
        }

        public int Strike()
        {
            return base.Weapon.DamagePoints + 15;
        }

        public int Execute()
        {
            throw new NotImplementedException();
        }

        public int SkinHarden()
        {
            return base.BodyArmor.ArmorPoints + 25;
        }

        public override int Attack()
        {
            return this.Strike();
        }

        public override int Defend()
        {
            return this.SkinHarden();
        }

        public override int SpecialAttack()
        {
            return this.Execute();
        }
    }
}
