namespace PA4
{
    public class JeffLucas : Character
    {
        private int attackStrength = 0;
        private int defensivePower = 0;

        public JeffLucas() : base("Jeff Lucas", 85)
        {
            attackStrength = rand.Next(1, MaxPower + 1);
            defensivePower = rand.Next(1, MaxPower + 1);
        }

        public override void Attack(Character opponent)
        {
            opponent.TakeDamage(attackStrength);
        }

        public override void Defend()
        {
            Health += defensivePower;
            if (Health > 100)
            {
                Health = 100;
            }
        }

        public override void PrintStats()
        {
            System.Console.WriteLine("Name: {0}\nHealth: {1}\nMax Power: {2}\nAttack Strength: {3}\nDefensive Power: {4}", Name, Health, MaxPower, AttackStrength, DefensivePower);
        }
    }
}