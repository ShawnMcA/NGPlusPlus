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
                health: 20 + (10 * level),
                mana: 5 + level,
                attack: 10 * level,
                defense: 15 + 5 * level,
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
                new Damage("Nibble", TargetType.Other, DamageType.Physical, 0, 100, 90),
                new Damage("Strong Bite", TargetType.Other, DamageType.Physical, 2, 120, 70),
                new Debuff("Scary Screech", TargetType.Other, StatType.Attack, 3, level * 3)
            };

            return abilities;
        }
    }

}