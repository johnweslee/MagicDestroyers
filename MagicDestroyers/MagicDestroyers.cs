using MagicDestroyers.Characters;
using MagicDestroyers.Characters.Melee;
using MagicDestroyers.Characters.Spellcasters;

namespace MagicDestroyers
{
    class MagicDestroyers
    {
        public static void Main()
        {
            //Console.WriteLine("Project Magic Destroyers");

            //Initialize Melee
            Character assaassin = new Assassin();
            Character knight = new Knight();
            Character warrior = new Warrior();

            //Initialize SpellCasters
            Character druid = new Druid();
            Character mage = new Mage();
            Character necromancer = new Necromancer();

            List<Character> teamMelee = new List<Character>();
            List<Character> teamSpellcaster = new List<Character>();

            teamMelee.Add(assaassin);
            teamMelee.Add(knight);
            teamMelee.Add(warrior);

            teamSpellcaster.Add(druid);
            teamSpellcaster.Add(mage);
            teamSpellcaster.Add(necromancer);
        }
    }
}