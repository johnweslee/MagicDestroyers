using MagicDestroyers.Characters.Interfaces;
using MagicDestroyers.Enumerations;
using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Weapons;

namespace MagicDestroyers.Characters
{
    public abstract class Character : IAttack, IDefend
    {
        private int healthPoints;
        private int level;
        private int score;

        private bool isAlive;

        private string name;

        private Faction faction;

        private Armor bodyArmor;
        private Weapon weapon;

        public int HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    this.healthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Invalid health points! It should be between the range 0 to 100.");
                }
            }
        }

        public int Level
        {
            get
            {
                return this.level;
            }
            set
            {
                if (value >= 0)
                {
                    this.level = value;
                }
            }
        }

        public Faction Faction
        {
            get
            {
                return this.faction;
            }
            set
            {
                this.faction = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length >= 3 && value.Length <= 16)
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException(string.Empty, "Invalid name! The length of the name shoulde be between 3 to 16 characters.");
                }
            }
        }

        public Armor BodyArmor
        {
            get
            {
                return this.bodyArmor;
            }
            set
            {
                this.bodyArmor = value;
            }
        }

        public Weapon Weapon
        {
            get
            {
                return this.weapon;
            }
            set
            {
                this.weapon = value;
            }
        }

        public bool ISAlive
        {
            get
            {
                return this.isAlive;
            }
            set
            {
                this.isAlive = value;
            }
        }

        public int Score {
            get
            {
                return this.score;
            }
            set
            {
                this.score = value;
            }
        }

        public abstract int Attack();
        public abstract int Defend();
        public abstract int SpecialAttack();

        public void takeDamage(int damage, string attackerName)
        {
            if(this.Defend() < damage)
            {
                this.healthPoints = this.healthPoints - damage + this.Defend();
                if(this.healthPoints <= 0)
                {
                    this.isAlive = false;
                }

            }
            else
            {
                Console.WriteLine("Haha! Your damage was not enough to harm me");
            }

            if (!this.isAlive)
            {
                Console.WriteLine($"{this.name} received damage {damage} from {attackerName}, and is dead now!");
            }
            else
            {
                Console.WriteLine($"{this.name} received damage {damage} from {attackerName}, and now has {this.healthPoints} health points");
            }
        }

        public void WonBattle()
        {
            this.score++;

            if(this.score % 10 == 0)
            {
                this.level++;
            }
        }
    }
}
