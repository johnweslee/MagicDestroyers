using MagicDestroyers.Equipment.Armors.Light;
using MagicDestroyers.Equipment.Weapons.Blunt;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Mage : Spellcaster
    {
        private readonly ClothRobe DEFAULT_BODY_ARMOR = new ClothRobe();
        private readonly Staff DEFAULT_WEAPON = new Staff();

        public Mage() : this(Constants.Mage.DEFAULT_NAME, Constants.Mage.DEFAULT_LEVEL)
        {
            
        }

        public Mage(string name, int level) : this(name, level, Constants.Mage.DEFAULT_HEALTH_POINTS)
        {
            
        }

        public Mage(string name, int level, int healthPoints)
        {
            base.ManaPoints = Constants.Mage.DEFAULT_MANA_POINTS;
            base.HealthPoints = healthPoints;
            base.Level = level;
            base.Faction = Constants.Mage.DEFAULT_FACTION;
            base.Name = name;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
            base.ISAlive = true;
            base.Score = 0;
        }

        public int ArcaneWrath()
        {
            return base.Weapon.DamagePoints + 10;
        }

        public int Firewall()
        {
            throw new NotImplementedException();
        }

        public int Meditation()
        {
            return base.BodyArmor.ArmorPoints + 10;
        }

        public override int Attack()
        {
            return this.ArcaneWrath();
        }

        public override int Defend()
        {
            return this.Meditation();
        }

        public override int SpecialAttack()
        {
            return this.Firewall();
        }
    }
}
