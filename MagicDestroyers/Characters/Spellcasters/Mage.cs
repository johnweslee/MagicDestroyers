using MagicDestroyers.Enumerations;
using MagicDestroyers.Equipment.Armors.Light;
using MagicDestroyers.Equipment.Weapons.Blunt;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Mage : Spellcaster
    {
        private const int DEFAULT_MANA_POINTS = 100;
        private const int DEFAULT_HEALTH_POINTS = 100;
        private const int DEFAULT_LEVEL = 0;

        private const Faction DEFAULT_FACTION = Faction.SpellCasters;
        private const string DEFAULT_NAME = "Mage";

        private readonly ClothRobe DEFAULT_BODY_ARMOR = new ClothRobe();
        private readonly Staff DEFAULT_WEAPON = new Staff();

        public Mage() : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
            
        }

        public Mage(string name, int level) : this(name, level, DEFAULT_HEALTH_POINTS)
        {
            
        }

        public Mage(string name, int level, int healthPoints)
        {
            base.ManaPoints = DEFAULT_MANA_POINTS;
            base.HealthPoints = healthPoints;
            base.Level = level;
            base.Faction = DEFAULT_FACTION;
            base.Name = name;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
        }

        public void ArcaneWrath()
        {
            throw new NotImplementedException();
        }

        public void Firewall()
        {
            throw new NotImplementedException();
        }

        public void Meditation()
        {
            throw new NotImplementedException();
        }

        public override void Attack()
        {
            this.ArcaneWrath();
        }

        public override void Defend()
        {
            this.Meditation();
        }

        public override void SpecialAttack()
        {
            this.Firewall();
        }
    }
}
