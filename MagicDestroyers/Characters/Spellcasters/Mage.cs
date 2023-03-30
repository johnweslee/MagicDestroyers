using MagicDestroyers.Enumerations;
using MagicDestroyers.Equipment.Armors.Light;
using MagicDestroyers.Equipment.Weapons.Blunt;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Mage : Spellcaster
    {
        private const int DEFAULT_ABILITY_POINTS = 100;
        private const int DEFAULT_HEALTH_POINTS = 100;
        private const int DEFAULT_LEVEL = 0;

        private const Faction DEFAULT_FACTION = Faction.SpellCasters;
        private const string DEFAULT_NAME = "Mage";

        private readonly ClothRobe DEFAULT_BODY_ARMOR = new ClothRobe();
        private readonly Staff DEFAULT_WEAPON = new Staff();

        private ClothRobe bodyArmor;
        private Staff weapon;

        public ClothRobe BodyArmor
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

        public Mage() : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
            
        }

        public Mage(string name, int level) : this(name, level, DEFAULT_HEALTH_POINTS)
        {
            
        }

        public Mage(string name, int level, int healthPoints)
        {
            this.ManaPoints = DEFAULT_ABILITY_POINTS;
            this.HealthPoints = healthPoints;
            this.Level = level;
            this.Faction = DEFAULT_FACTION;
            this.Name = name;
            this.BodyArmor = DEFAULT_BODY_ARMOR;
            this.Weapon = DEFAULT_WEAPON;
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
            throw new NotImplementedException();
        }

        public override void Defend()
        {
            throw new NotImplementedException();
        }

        public override void SpecialAttack()
        {
            throw new NotImplementedException();
        }
    }
}
