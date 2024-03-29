﻿using MagicDestroyers.Equipment.Interfaces;

namespace MagicDestroyers.Equipment.Weapons.Blunt
{
    public class Hammer : Blunt
    {
        private const int DEFAULT_DAMAGE_POINTS = 5;

        public Hammer() : this(DEFAULT_DAMAGE_POINTS)
        {

        }

        public Hammer(int damagePoints)
        {
            this.DamagePoints = damagePoints;
        }

        public override void SpecialAbility()
        {
            this.Stun();
        }

        public void Stun()
        {
            throw new NotImplementedException();
        }
    }
}
