using MagicDestroyers.Characters;
using MagicDestroyers.Characters.Melee;
using MagicDestroyers.Characters.Spellcasters;

namespace MagicDestroyers
{
    class MagicDestroyers
    {
        public static void Main()
        {
            Random random = new Random();

            int currentMelee = 0, currentSpellCaster = 0;
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
                currentMelee = random.Next(0, teamMelee.Count);
                currentSpellCaster = random.Next(0, teamSpellCaster.Count);

                teamSpellCaster[currentSpellCaster].takeDamage(teamMelee[currentMelee].Attack(), teamMelee[currentMelee].Name);

                if (!teamSpellCaster[currentSpellCaster].ISAlive)
                {
                    teamMelee[currentMelee].WonBattle();
                    teamSpellCaster.Remove(teamSpellCaster[currentSpellCaster]);

                    if(teamSpellCaster.Count == 0)
                    {
                        Console.WriteLine("Melee team wins");
                        break;
                    }
                    else
                    {
                        currentSpellCaster = random.Next(0, teamSpellCaster.Count);
                    }
                }

                teamMelee[currentMelee].takeDamage(teamSpellCaster[currentSpellCaster].Attack(), teamSpellCaster[currentSpellCaster].Name);

                if (!teamMelee[currentMelee].ISAlive)
                {
                    teamSpellCaster[currentSpellCaster].WonBattle();
                    teamMelee.Remove(teamMelee[currentMelee]);

                    if (teamMelee.Count == 0)
                    {
                        Console.WriteLine("SpellCaster team wins");
                        break;
                    }
                    else
                    {
                        currentMelee = random.Next(0, teamMelee.Count);
                    }
                }
            }
        }
    }
}