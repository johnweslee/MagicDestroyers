namespace MagicDestroyers.Equipment.Weapons.Sharp
{
    public class Sword : Sharp
    {
        private const int DEFAULT_DAMAGE_POINTS = 20;

        public Sword() : this(DEFAULT_DAMAGE_POINTS)
        {

        }

        public Sword(int damagePoints)
        {
            this.DamagePoints = damagePoints;
        }

        public void Bloodthirst()
        {
            throw new NotImplementedException();
        }

        public override void SpecialAbility()
        {
            this.Bloodthirst();
        }
    }
}
