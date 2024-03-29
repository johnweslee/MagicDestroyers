﻿namespace MagicDestroyers.Equipment.Weapons.Sharp
{
    public class Axe : Sharp
    {
        private const int DEFAULT_DAMAGE_POINTS = 15;

        public Axe() : this(DEFAULT_DAMAGE_POINTS)
        {

        }

        public Axe(int damagePoints)
        {
            this.DamagePoints = damagePoints;
        }

        public override void SpecialAbility()
        {
            this.HackNSlash();
        }

        public void HackNSlash()
        {
            throw new NotImplementedException();
        }
    }
}
