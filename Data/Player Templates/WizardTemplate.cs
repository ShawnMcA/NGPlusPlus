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
                health: 70 + (10 * level),
                mana: 6 + level,
                attack: 10 * level,
                defense: 7 + 5 * level,
                magicAttack: 15 * level,
                magicDefense: 15 * level,
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
                new Damage("Bonk!", TargetType.Other, DamageType.Physical, 0, 100, 95),
                new Damage("Flare", TargetType.Other, DamageType.Magic, 3 * level, 120, 85)
            };

            if (level >= 3)
            {
                abilities.Add(new Debuff("Magic Def. Down", TargetType.Other, StatType.MagicDefense, 3 * level, 3 * level));
            }

            if (level >= 5)
            {
                abilities.Add(new Damage("Fire Ball", TargetType.Other, DamageType.Magic, 5 * level, 4, 80));
            }

            if (level >= 9)
            {
                abilities.Add(new Damage("Meteor", TargetType.OtherAll, DamageType.Magic, 10 * level, 6, 70));
            }

            return abilities;
        }
    }
}

