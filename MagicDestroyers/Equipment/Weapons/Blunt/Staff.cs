namespace MagicDestroyers.Equipment.Weapons.Blunt
{
    public class Staff : Blunt
    {
        private const int DEFAULT_DAMAGE_POINTS = 10;

        public Staff() : this(DEFAULT_DAMAGE_POINTS)
        {

        }

        public Staff(int damagePoints)
        {
            this.DamagePoints = damagePoints;
        }

        public override void Buff()
        {
            throw new NotImplementedException();
        }

        public void Empower()
        {
            throw new NotImplementedException();
        }
    }
}
