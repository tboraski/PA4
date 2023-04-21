namespace PA4
{
    public class JeffLucasAttack : IAttackBehavior
    {
        public void Attack(Character self, Character opponent)
        {
            int damage = self.AttackStrength;

            //50% bonus damage
            if (opponent is JackSparrow)
            {
                damage += (int)(damage * 0.5);
            }
            if (opponent is WillTurner)
            {
                damage += (int)(damage * 0.5);
            }
            if (opponent is DavyJones)
            {
                damage += (int)(damage * 0.5);
            }

            opponent.TakeDamage(damage);
        }
    }
}