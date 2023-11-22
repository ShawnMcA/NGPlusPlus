using NGPlusPlus.Abilities;
using NGPlusPlus.Enums;
using NGPlusPlus.Interfaces;
using NGPlusPlus.StatsNamespace;

namespace NGPlusPlus.Data {
    public class RatTemplate : IEnemyTemplate 
    {
        public RatTemplate(int level)
        {
            ExperienceGiven = 5 * level;

            Stats = new Stats(
                level,
                health: 20 * level,
                mana: 5 * level,
                attack: 5 * level,
                defense: 5 * level,
                magicAttack: 5 * level,
                magicDefense: 5 * level,
                speed: 5 * level
            );

            Abilities = AbilityShop(level);
        }

        public int ExperienceGiven { get; private set; }
        public IStats Stats { get; private set; }
        public List<IAbility> Abilities { get; private set; }

        private List<IAbility> AbilityShop(int level)
        {
            var abilities = new List<IAbility>();

            abilities.Add(new Damage("Attack", TargetType.Other, DamageType.Physical, 0, level, level));
            abilities.Add(new Damage("Strong Bite", TargetType.Other, DamageType.Physical, 0, level * 2, level * 2));

            return abilities;
        }
    }

}