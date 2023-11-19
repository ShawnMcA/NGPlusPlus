using RPGGame.Enums;
using RPGGame.Interfaces;

namespace RPGGame.Abilities
{
    public class Heal : IAbility
    {
        public string Name { get; }
        public AbilityType AbilityType { get; } = AbilityType.Heal;
        public DamageType DamageType { get; } = DamageType.None;
        public TargetType TargetType { get; }
        public int ManaCost { get; }
        public int Amount { get; }

        public Heal(string name, TargetType targetType, int manaCost, int amount) 
        { 
            Name = name;
            TargetType = targetType;
            ManaCost = manaCost;
            Amount = amount;
        }
    }
}
