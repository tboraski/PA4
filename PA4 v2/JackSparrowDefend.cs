 namespace PA4
{
    public class JackSparrowDefend : IDefendBehavior
    {

        private Random rand = new Random();

        public void Defend(Character self, Character opponent, int incomingDamage)
        {
            //Can dodge an attack with a 33% probability(special to Jack Sparrow)
            if (rand.Next(1,101) <= 33)
            {
                System.Console.WriteLine("{0} dodged the attack!", self.Name);
            }

            //basic defense reduces damage by 20%
            else
            {
                int damageTaken = (int)(incomingDamage * 0.8);
                self.Health -= damageTaken;
                System.Console.WriteLine("{0} took {1} damage from {2}'s attack!", self.Name, damageTaken, opponent.Name);
            }
        }
    }
}