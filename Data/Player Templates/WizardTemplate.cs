using NGPlusPlus.Abilities;
using NGPlusPlus.Enums;
using NGPlusPlus.Interfaces;
using NGPlusPlus.StatsNamespace;

namespace NGPlusPlus.Data
{
    public class WizardTemplate: IPlayerTemplate
    {
        public WizardTemplate(int level) 
        {
            ExperienceNeeded = 50 * level;

            Stats = new Stats(
                level,
                health: 8 * level,
                mana: 5 * level,
                attack: 2 * level,
                defense: 3 * level,
                magicAttack: 6 * level,
                magicDefense: 5 * level,
                speed: 5 * level
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
                new Damage("Flare", TargetType.Other, DamageType.Magic, 3 * level, 0, 2 * level)
            };

            if (level >= 3)
            {
                abilities.Add(new Debuff("Magic Def. Down", TargetType.Other, StatType.MagicDefense, 3 * level, 3 * level));
            }

            if (level >= 5)
            {
                abilities.Add(new Damage("Fire Ball", TargetType.Other, DamageType.Magic, 5 * level, 3 * level, 5 * level));
            }

            if (level >= 9)
            {
                abilities.Add(new Damage("Meteor", TargetType.OtherAll, DamageType.Magic, 10 * level, 5 * level, 8 * level));
            }

            return abilities;
        }
    }
}

