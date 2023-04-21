namespace PA4
{
    public interface IDefendBehavior
    {
        public void Defend(Character self, Character opponent, int incomingAttackStrength);
    }
}