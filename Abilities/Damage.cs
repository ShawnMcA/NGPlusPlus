using RPGGame.Enums;
using RPGGame.Interfaces;

namespace RPGGame.Abilities
{
    public class Damage : IAbility
    {
        public string Name { get; }
        public AbilityType AbilityType { get; } = AbilityType.Damage;
        public DamageType DamageType { get; }
        public TargetType TargetType { get; }
        public int ManaCost { get; }
        public int RangeLow { get; }
        public int RangeHigh { get; }

        public Damage(string name, TargetType targetType, DamageType damagetype, int manaCost, int rangeLow, int rangeHigh) 
        { 
            Name = name;
            TargetType = targetType;
            DamageType = damagetype;
            ManaCost = manaCost;
            RangeLow = rangeLow;
            RangeHigh = rangeHigh;
        }
    }
}
