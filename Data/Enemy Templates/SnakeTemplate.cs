using NGPlusPlus.Abilities;
using NGPlusPlus.Enums;
using NGPlusPlus.Interfaces;
using NGPlusPlus.StatsNamespace;

namespace NGPlusPlus.Data {
    public class SnakeTemplate : IEnemyTemplate 
    {
        public SnakeTemplate(int level)
        {
            ExperienceGiven = 25 * level;

            Stats = new Stats(
                level,
                health: 30 + (10 * level),
                mana: 5 + level,
                attack: 13 * level,
                defense: 10 + 5 * level,
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
                new Damage("Chow Down", TargetType.Other, DamageType.Physical, 3, 120, 70),
                new Heal("Heal Self", TargetType.Self, 5 * level, level * 10)
            };

            return abilities;
        }
    }

}