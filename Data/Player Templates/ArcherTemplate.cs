using NGPlusPlus.Abilities;
using NGPlusPlus.Enums;
using NGPlusPlus.Interfaces;
using NGPlusPlus.StatsNamespace;

namespace NGPlusPlus.Data
{
    public class ArcherTemplate: IPlayerTemplate
    {
        public ArcherTemplate(int level) 
        {
            ExperienceNeeded = 50 * level;

            Stats = new Stats(
                level,
                health: 40 * level,
                mana: 7 * level,
                attack: 10 * level,
                defense: 7 * level,
                magicAttack: 5 * level,
                magicDefense: 5 * level,
                speed: 10 * level
            );

            Abilities = AbilityShop(level);
        }

        public int ExperienceNeeded { get; private set; }
        public IStats Stats { get; private set; }
        public List<IAbility> Abilities { get; private set; }

        private List<IAbility> AbilityShop(int level)
        {
            var abilities = new List<IAbility>();

            abilities.Add(new Damage("Attack", TargetType.Other, DamageType.Physical, 0, 1 * level, 1 * level));
            abilities.Add(new Damage("Quick Shot", TargetType.Other, DamageType.Physical, 3 * level, 1 * level, 3 * level));

            if (level >= 3)
            {
                abilities.Add(new Heal("Heal Self", TargetType.Self, 3 * level, 15 * level));
            }

            if (level >= 5)
            {
                abilities.Add(new Buff("Attack Up", TargetType.Self, StatType.Attack, 3 * level, 3 * level));
            }

            if (level >= 9)
            {
                abilities.Add(new Damage("Ohh Hail No", TargetType.OtherAll, DamageType.Physical, 5 * level, 5 * level, 8 * level));
            }

            return abilities;
        }
    }
}

