using MagicDestroyers.Characters;
using MagicDestroyers.Characters.Melee;
using MagicDestroyers.Characters.Spellcasters;

namespace MagicDestroyers
{
    class MagicDestroyers
    {
        public static void Main()
        {
            bool gameOver = false;

            List<Character> characters = new List<Character>()
            {
                new Assassin(), new Knight(), new Warrior(),
                new Druid(), new Mage(), new Necromancer()
            };

            List<Melee> teamMelee = new List<Melee>();
            List<Spellcaster> teamSpellCaster = new List<Spellcaster>();

            foreach (Character character in characters)
            {
                if (character is Melee)
                {
                    teamMelee.Add((Melee)character);
                }
                else if (character is Spellcaster)
                {
                    teamSpellCaster.Add((Spellcaster)character);
                }
            }

            while (!gameOver)
            {
                //select randon melee character
                //select random spellcaster character

                //melee attack spellcaster
                //check if character is dead then remove from team
                //get another character

                //spell attack melee
                //...same logic as melee
                //...same logic as melee

                //if all character die in team then game over
            }
        }
    }
}