using NGPlusPlus.Abilities;
using NGPlusPlus.Enums;
using NGPlusPlus.Interfaces;
using NGPlusPlus.StatsNamespace;

namespace NGPlusPlus.Data {
    public class SpiderTemplate : IEnemyTemplate 
    {
        public SpiderTemplate(int level)
        {
            ExperienceGiven = 5 * level;

            Stats = new Stats(
                level,
                health: 30 + (10 * level),
                mana: 5 + level,
                attack: 8 * level,
                defense: 20 + 5 * level,
                magicAttack: 3 * level,
                magicDefense: 2 * level,
                speed: 4 * level
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
                new Damage("Attack", TargetType.Other, DamageType.Physical, 0, 100, 90),
                new Damage("Strong Bite", TargetType.Other, DamageType.Physical, 0, 110, 80),
                new Heal("Heal Self", TargetType.Self, 3 * level, level * 3),
                new Debuff("Sticky Web", TargetType.Other, StatType.Speed, 3 * level, 999)
            };

            return abilities;
        }
    }

}