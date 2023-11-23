using NGPlusPlus.Enums;
using NGPlusPlus.Interfaces;

namespace NGPlusPlus.Abilities
{
    public class Debuff : IAbility
    {
        public string Name { get; }
        public AbilityType AbilityType { get; } = AbilityType.Debuff;
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
