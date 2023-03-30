namespace MagicDestroyers.Characters.Spellcasters
{
    public abstract class Spellcaster : Character
    {
        private int manaPoints;

        public int ManaPoints
        {
            get
            {
                return this.ManaPoints;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    this.ManaPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Invalid mana points! It should be between the range 0 to 100.");
                }
            }
        }
    }
}
