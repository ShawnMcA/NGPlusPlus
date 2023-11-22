namespace NGPlusPlus.Interfaces
{
    public interface IEnemyTemplate {
        int ExperienceGiven { get; }
        IStats Stats { get; }
        List<IAbility> Abilities { get; }
    }
}
