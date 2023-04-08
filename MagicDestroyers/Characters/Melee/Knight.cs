using MagicDestroyers.Enumerations;
using MagicDestroyers.Equipment.Armors.Heavy;
using MagicDestroyers.Equipment.Weapons.Blunt;
using System;

namespace MagicDestroyers.Characters.Melee
{
    public class Knight : Melee
    {
        private const int DEFAULT_ABILITY_POINTS = 100;
        private const int DEFAULT_HEALTH_POINTS = 100;
        private const int DEFAULT_LEVEL = 0;

        private const Faction DEFAULT_FACTION = Faction.Melee;
        private const string DEFAULT_NAME = "Knight";

        private readonly Chainlink DEFAULT_BODY_ARMOR = new Chainlink();
        private readonly Hammer DEFAULT_WEAPON = new Hammer();

        public Knight() : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
            
        }

        public Knight(string name, int level) : this(name, level, DEFAULT_HEALTH_POINTS)
        {
            
        }

        public Knight(string name, int level, int healthPoints)
        {
            base.AbilityPoints = DEFAULT_ABILITY_POINTS;
            base.HealthPoints = healthPoints;
            base.Level = level;
            base.Faction = DEFAULT_FACTION;
            base.Name = name;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
        }

        public void HolyBow()
        {
            throw new NotImplementedException();
        }

        public void PurifySoul()
        {
            throw new NotImplementedException();
        }

        public void RighteousWings()
        {
            throw new NotImplementedException();
        }

        public override void Attack()
        {
            this.HolyBow();
        }

        public override void Defend()
        {
            this.RighteousWings();
        }

        public override void SpecialAttack()
        {
            this.PurifySoul();
        }
    }
}
