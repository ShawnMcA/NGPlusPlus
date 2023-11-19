using RPGGame.Enums;

namespace RPGGame.Interfaces
{
    public interface IAbility
    {
        string Name { get; }
        public AbilityType AbilityType { get; }
        public TargetType TargetType { get; }
        public DamageType DamageType { get; }
        public int ManaCost { get; }
    }
}
