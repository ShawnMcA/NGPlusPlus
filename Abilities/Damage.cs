using NGPlusPlus.Enums;
using NGPlusPlus.Interfaces;

namespace NGPlusPlus.Abilities
{
    public class Damage : IAbility
    {
        public string Name { get; }
        public AbilityType AbilityType { get; } = AbilityType.Damage;
        public DamageType DamageType { get; }
        public TargetType TargetType { get; }
        public int ManaCost { get; }
        public int BaseDamage { get; }
        public int Accuracy { get; }

        public Damage(string name, TargetType targetType, DamageType damagetype, int manaCost, int baseDamage, int accuracy) 
        { 
            Name = name;
            TargetType = targetType;
            DamageType = damagetype;
            ManaCost = manaCost;
            BaseDamage = baseDamage;
            Accuracy = accuracy;
        }
    }
}
