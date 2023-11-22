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
                health: 50 * level,
                mana: 5 * level,
                attack: 8 * level,
                defense: 10 * level,
                magicAttack: 5 * level,
                magicDefense: 8 * level,
                speed: 7 * level
            );

            Abilities = AbilityShop(level);
        }

        public int ExperienceNeeded { get; private set; }
        public IStats Stats { get; private set; }
        public List<IAbility> Abilities { get; private set;  }

        private List<IAbility> AbilityShop(int level)
        {
            var abilities = new List<IAbility>();

            abilities.Add(new Damage("Attack", TargetType.Other, DamageType.Physical, 0, 1 * level, 1 * level));
            abilities.Add(new Buff("Defense Up", TargetType.Self, StatType.Defense, 2 * level, 3 * level));

            if (level >= 3)
            {
                abilities.Add(new Heal("Heal Self", TargetType.Self, 3 * level, 25 * level));
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

