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
                health: 10 * level,
                mana: 3 * level,
                attack: 5 * level,
                defense: 3 * level,
                magicAttack: 3 * level,
                magicDefense: 3 * level,
                speed: 6 * level
            );

            Abilities = AbilityShop(level);
        }

        public int ExperienceNeeded { get; private set; }
        public IStats Stats { get; private set; }
        public List<IAbility> Abilities { get; private set; }

        private List<IAbility> AbilityShop(int level)
        {
            var abilities = new List<IAbility>
            {
                new Damage("Attack", TargetType.Other, DamageType.Physical, 0, level, level + (1 * level)),
                new Buff("Attack Up", TargetType.Self, StatType.Attack, 2 * level, 2 * level)
            };

            if (level >= 3)
            {
                abilities.Add(new Heal("Heal Self", TargetType.Self, 3 * level, 15 * level));
            }

            if (level >= 5)
            {
                abilities.Add(new Damage("Wild Shot", TargetType.Other, DamageType.Physical, 0, 0, 3 * level));
            }

            if (level >= 9)
            {
                abilities.Add(new Damage("Ohh Hail No", TargetType.OtherAll, DamageType.Physical, 5 * level, 5 * level, 8 * level));
            }

            return abilities;
        }
    }
}

