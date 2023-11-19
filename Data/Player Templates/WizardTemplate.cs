using RPGGame.Abilities;
using RPGGame.Enums;
using RPGGame.Interfaces;
using System.Collections.Generic;

namespace RPGGame.Data
{
    public class WizardTemplate: IPlayerTemplate
    {
        public WizardTemplate(int level) 
        {
            ExperienceNeeded = 50 * level;
            MaxHealth = 30 * level;
            MaxMana = 10 * level;
            Attack = 5 * level;
            Defense = 5 * level;
            MagicAttack = 10 * level;
            MagicDefense = 10 * level;
            Speed = 7 * level;
            Abilities = new List<IAbility>();

            AbilityShop(level);
        }

        public int ExperienceNeeded { get; }
        public int MaxHealth { get; }
        public int MaxMana { get; }
        public int Attack { get; }
        public int Defense { get; }
        public int MagicAttack { get; }
        public int MagicDefense { get; }
        public int Speed { get; }
        public List<IAbility> Abilities { get; private set; }

        private void AbilityShop(int level)
        {
            Abilities.Add(new Damage("Attack", TargetType.Other, DamageType.Physical, 0, 1 * level, 1 * level));
            Abilities.Add(new Damage("Flare", TargetType.Other, DamageType.Magic, 3 * level, 1 * level, 3 * level));

            if (level >= 3)
            {
                Abilities.Add(new Debuff("Magic Def. Down", TargetType.Other, StatType.MagicDefense, 3 * level, 3 * level));
            }

            if (level >= 5)
            {
                Abilities.Add(new Damage("Fire Ball", TargetType.Other, DamageType.Magic, 5 * level, 3 * level, 5 * level));
            }

            if (level >= 9)
            {
                Abilities.Add(new Damage("Meteor", TargetType.OtherAll, DamageType.Magic, 10 * level, 5 * level, 8 * level));
            }
        }
    }
}

