namespace PA4
{
    public class JackSparrowAttack : IAttackBehavior
    {
        public void Attack(Character self, Character opponent)
        {
            int damage = self.AttackStrength;

            //20% damage bonus towards Will Turner
            if (opponent is WillTurner)
            {
                damage += (int)(damage * 0.2);
            }

            opponent.TakeDamage(damage);
        }
    }
}