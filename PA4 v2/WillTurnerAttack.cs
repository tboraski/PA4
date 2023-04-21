namespace PA4
{
    public class WillTurnerAttack : IAttackBehavior
    {
        public void Attack(Character self, Character opponent)
        {
            int damage = self.AttackStrength;

            //20% damage bonus towards Davy Jones
            if (opponent is DavyJones)
            {
                damage += (int)(damage * 0.2);
            }

            opponent.TakeDamage(damage);
        }
    }
}