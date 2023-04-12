using MagicDestroyers.Enumerations;
using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Weapons.Sharp;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Necromancer : Spellcaster
    {
        private const int DEFAULT_MANA_POINTS = 100;
        private const int DEFAULT_HEALTH_POINTS = 100;
        private const int DEFAULT_LEVEL = 0;

        private const Faction DEFAULT_FACTION = Faction.SpellCasters;
        private const string DEFAULT_NAME = "Necromancer";

        private readonly LeatherLightVest DEFAULT_BODY_ARMOR = new LeatherLightVest();
        private readonly Sword DEFAULT_WEAPON = new Sword();

        public Necromancer() : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
            
        }

        public Necromancer(string name, int level) : this(name, level, DEFAULT_HEALTH_POINTS)
        {
            
        }

        public Necromancer(string name, int level, int healthPoints)
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

        public int ShadowRage()
        {
            return base.Weapon.DamagePoints + 10;
        }

        public int VampireTouch()
        {
            throw new NotImplementedException();
        }

        public int BoneShiled()
        {
            return base.BodyArmor.ArmorPoints + 5;
        }

        public override int Attack()
        {
            return this.ShadowRage();
        }

        public override int Defend()
        {
            return this.BoneShiled();
        }

        public override int SpecialAttack()
        {
            return this.VampireTouch();
        }
    }
}
