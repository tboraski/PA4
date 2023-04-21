namespace PA4
{
    public class JeffLucasDefend : IDefendBehavior
    {
        public void Defend(Character self, Character opponent, int incomingDamage)
        {
            //basic defense reduces damage by 50%
            int damageTaken = (int)(incomingDamage * 0.5);
            self.Health -= damageTaken;
            System.Console.WriteLine("{0} took {1} damage from {2}'s attack!", self.Name, damageTaken, opponent.Name);
        }
    }
}