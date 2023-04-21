namespace PA4
{
    public class DavyJones : Character
    {
        public DavyJones(string name) : base(name, 70)
        {
            AttackBehavior = new DavyJonesAttack();
            DefensiveBehavior = new DavyJonesDefend();
        }

        public override void Attack(Character opponent)
        {
            int attackPower = GenerateRandomNumber(1, MaxPower);
            int defenseReduction = GenerateRandomNumber(1, MaxPower);
            opponent.Health -= attackPower;
            opponent.DefensivePower -= defenseReduction;
            System.Console.WriteLine($"{Name} attacks {opponent.Name} for {attackPower} damage and lowers their defense by {defenseReduction} points!");
        }

        private int GenerateRandomNumber(int v, int maxPower)
        {
            throw new NotImplementedException();
        }

        public override void PrintStats()
        {
            System.Console.WriteLine("Name: {0}\nHealth: {1}\nMax Power: {2}\nAttack Strength: {3}\nDefensive Power: {4}", Name, Health, MaxPower, AttackStrength, DefensivePower);
        }

        public override void Defend()
        {
            throw new NotImplementedException();
        }
    }
}