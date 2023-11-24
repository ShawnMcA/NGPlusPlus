using NGPlusPlus.Abilities;
using NGPlusPlus.Enums;
using NGPlusPlus.Interfaces;
using NGPlusPlus.StatsNamespace;

namespace NGPlusPlus.Data {
    public class Snake : IEnemyTemplate 
    {
        public Snake(int level)
        {
            ExperienceGiven = 5 * level;

            Stats = new Stats(
                level,
                health: 8 * level,
                mana: 3 * level,
                attack: 4 * level,
                defense: 3 * level,
                magicAttack: 5 * level,
                magicDefense: 3 * level,
                speed: 3 * level
            );

            Abilities = AbilityShop(level);
        }

        public int ExperienceGiven { get; private set; }
        public IStats Stats { get; private set; }
        public List<IAbility> Abilities { get; private set; }

        private List<IAbility> AbilityShop(int level)
        {
            var abilities = new List<IAbility>
            {
                new Damage("Attack", TargetType.Other, DamageType.Physical, 0, level, level),
                new Damage("Strong Bite", TargetType.Other, DamageType.Physical, 0, level, level + (2 * level)),
                new Heal("Heal Self", TargetType.Self, 3 * level, level * 3),
                new Debuff("Sticky Web", TargetType.Other, StatType.Speed, 3 * level, 999)
            };

            return abilities;
        }
    }

}