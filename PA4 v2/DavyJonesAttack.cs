namespace PA4
{
    public class DavyJonesAttack : IAttackBehavior
    {
        public void Attack(Character self, Character opponent)
        {
            int damage = self.AttackStrength;

            //20% damage bonus towards Jack Sparrow
            if (opponent is JackSparrow)
            {
                damage += (int)(damage * 0.2);
            }

            opponent.TakeDamage(damage);
        }
    }
}