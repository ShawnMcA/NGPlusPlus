using NGPlusPlus.Abilities;
using NGPlusPlus.Enums;
using NGPlusPlus.Interfaces;
using NGPlusPlus.StatsNamespace;

namespace NGPlusPlus.Data {
    public class Rat : IEnemyTemplate 
    {
        public Rat(int level)
        {
            ExperienceGiven = 5 * level;

            Stats = new Stats(
                level,
                health: 5 * level,
                mana: 3 * level,
                attack: 3 * level,
                defense: 2 * level,
                magicAttack: 3 * level,
                magicDefense: 2 * level,
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
                new Damage("Strong Bite", TargetType.Other, DamageType.Physical, 0, level * 2, level * 2)
            };

            return abilities;
        }
    }

}