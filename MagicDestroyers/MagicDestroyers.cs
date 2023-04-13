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

            Melee currentMelee;
            Spellcaster currentSpellCaster;

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
                currentMelee = teamMelee[random.Next(0, teamMelee.Count)];
                currentSpellCaster = teamSpellCaster[random.Next(0, teamSpellCaster.Count)];

                currentSpellCaster.takeDamage(currentMelee.Attack(), currentMelee.Name, currentMelee.GetType().ToString());
                if (!currentSpellCaster.ISAlive)
                {
                    currentMelee.WonBattle();
                    teamSpellCaster.Remove(currentSpellCaster);

                    if(teamSpellCaster.Count == 0)
                    {
                        MagicDestroyersTools.ColorfulWriteLine("***Melee team wins***", ConsoleColor.Green);
                        break;
                    }
                    else
                    {
                        currentSpellCaster = teamSpellCaster[random.Next(0, teamSpellCaster.Count)];
                    }
                }

                currentMelee.takeDamage(currentSpellCaster.Attack(), currentSpellCaster.Name, currentSpellCaster.GetType().ToString());
                if (!currentMelee.ISAlive)
                {
                    currentSpellCaster.WonBattle();
                    teamMelee.Remove(currentMelee);

                    if (teamMelee.Count == 0)
                    {
                        Console.WriteLine("***SpellCaster team wins***", ConsoleColor.Green);
                        break;
                    }
                    else
                    {
                        currentMelee = teamMelee[random.Next(0, teamMelee.Count)];
                    }
                }
            }
        }
    }
}