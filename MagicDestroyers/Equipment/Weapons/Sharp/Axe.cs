namespace MagicDestroyers.Equipment.Weapons.Sharp
{
    public class Axe : Sharp
    {
        private const int DEFAULT_DAMAGE_POINTS = 10;

        public Axe() : this(DEFAULT_DAMAGE_POINTS)
        {

        }

        public Axe(int damagePoints)
        {
            this.DamagePoints = damagePoints;
        }

        public override void Buff()
        {
            throw new NotImplementedException();
        }

        public void HackNSlash()
        {
            throw new NotImplementedException();
        }
    }
}
