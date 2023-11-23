using NGPlusPlus.Abilities;
using NGPlusPlus.Enums;
using NGPlusPlus.Interfaces;
using NGPlusPlus.StatsNamespace;

namespace NGPlusPlus.Data
{
    public class KnightTemplate: IPlayerTemplate
    {
        public KnightTemplate(int level) 
        {
            ExperienceNeeded = 50 * level;

            Stats = new Stats(
                level, 
                health: 12 * level,
                mana: 3 * level,
                attack: 4 * level,
                defense: 5 * level,
                magicAttack: 2 * level,
                magicDefense: 4 * level,
                speed: 4 * level
            );

            Abilities = AbilityShop(level);
        }

        public int ExperienceNeeded { get; private set; }
        public IStats Stats { get; private set; }
        public List<IAbility> Abilities { get; private set;  }

        private List<IAbility> AbilityShop(int level)
        {
            var abilities = new List<IAbility>
            {
                new Damage("Attack", TargetType.Other, DamageType.Physical, 0, level, level + (1 * level)),
                new Buff("Defense Up", TargetType.Self, StatType.Defense, 2 * level, 2 * level)
            };

            if (level >= 3)
            {
                abilities.Add(new Heal("Heal Self", TargetType.Self, 3 * level, 3 * level));
            }

            if (level >= 5)
            {
                abilities.Add(new Damage("Heavy Swing", TargetType.Other, DamageType.Physical, 3 * level, 3 * level, 5 * level));
            }

            if (level >= 9)
            {
                abilities.Add(new Damage("Spear Wall", TargetType.OtherAll, DamageType.Physical, 4 * level, 5 * level, 8 * level));
            }

            return abilities;
        }
    }
}

