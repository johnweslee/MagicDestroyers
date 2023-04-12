namespace MagicDestroyers
{
    public static class MagicDestroyersTools
    {
        public static void ColorfulWriteLine(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void CharacterSpecificColor(string message, string type)
        {
            ConsoleColor color = ConsoleColor.White;
            switch (type)
            {
                case "MagicDestroyers.Characters.Melee.Assassin":
                    color = ConsoleColor.Magenta;
                    break;
                case "MagicDestroyers.Characters.Melee.Knight":
                    color = ConsoleColor.Cyan;
                    break;
                case "MagicDestroyers.Characters.Melee.Warrior":
                    color = ConsoleColor.Red;
                    break;
                case "MagicDestroyers.Characters.Spellcasters.Druid":
                    color = ConsoleColor.DarkMagenta;
                    break;
                case "MagicDestroyers.Characters.Spellcasters.Mage":
                    color = ConsoleColor.DarkBlue;
                    break;
                case "MagicDestroyers.Character.Spellcasters.Necromancer":
                    color = ConsoleColor.DarkYellow;
                    break;
                default: 
                    color = ConsoleColor.White;
                    break;
            }
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
