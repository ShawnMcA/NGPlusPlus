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
                health: 80 + (10 * level),
                mana: 2 + level,
                attack: 15 * level,
                defense: 10 + 5 * level,
                magicAttack: 3 * level,
                magicDefense: 4 * level,
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
                new Damage("Weak Shot", TargetType.Other, DamageType.Physical, 0, 1, 95),
                new Buff("Attack Up", TargetType.Self, StatType.Attack, 2 * level, 2 * level)
            };

            if (level >= 3)
            {
                abilities.Add(new Heal("Heal Self", TargetType.Self, 3 * level, 15 * level));
            }

            if (level >= 5)
            {
                abilities.Add(new Damage("Wild Shot", TargetType.Other, DamageType.Physical, 0, 3, 70));
            }

            if (level >= 9)
            {
                abilities.Add(new Damage("Ohh Hail No", TargetType.OtherAll, DamageType.Physical, 5 * level, 5, 85));
            }

            return abilities;
        }
    }
}

