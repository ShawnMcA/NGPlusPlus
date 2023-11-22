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
                health: 30 * level,
                mana: 10 * level,
                attack: 5 * level,
                defense: 5 * level,
                magicAttack: 10 * level,
                magicDefense: 10 * level,
                speed: 7 * level
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
            abilities.Add(new Damage("Flare", TargetType.Other, DamageType.Magic, 3 * level, 1 * level, 3 * level));

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

