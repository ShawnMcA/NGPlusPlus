using RPGGame.Enums;
using RPGGame.Interfaces;

namespace RPGGame.Abilities
{
    public class Debuff : IAbility
    {
        public string Name { get; }
        public AbilityType AbilityType { get; } = AbilityType.Buff;
        public DamageType DamageType { get; } = DamageType.None;
        public TargetType TargetType { get; }
        public StatType StatType { get; }
        public int ManaCost { get; }
        public int Amount { get; }

        public Debuff(string name, TargetType targetType, StatType statType, int manaCost, int amount) 
        { 
            Name = name;
            TargetType = targetType;
            StatType = statType;
            ManaCost = manaCost;
            Amount = amount;
        }
    }
}
