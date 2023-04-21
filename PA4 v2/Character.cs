namespace PA4
{
    public abstract class Character
    {
        public string Name {get; }
        public int MaxPower {get; }
        public int Health {get; set; }
        public int AttackStrength {get; set; }
        public int DefensivePower {get; set; }
        protected IAttackBehavior AttackBehavior {get; set; }
        protected IDefendBehavior DefensiveBehavior {get; set; }

        protected Random rand = new Random();

        public Character(string name, int maxPower)
        {
            Name = name;
            MaxPower = maxPower;
            Health = 100;
            AttackStrength = rand.Next(1, MaxPower + 1);
            DefensivePower = rand.Next(1, MaxPower + 1);
        }

        public abstract void Attack(Character opponent);

        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health < 0)
            {
                Health = 0;
            }
        }

        public abstract void Defend();

        public int GetHealth()
        {
            return Health;
        }

        public int GetDefensivePower()
        {
            return DefensivePower;
        }
        public virtual void PrintStats()
        {
            System.Console.WriteLine("Name: {0}\nHealth: {1}\nMax Power: {2}\nAttack Strength: {3}\nDefensive Power: {4}", Name, Health, MaxPower, AttackStrength, DefensivePower);
        }
    }
}