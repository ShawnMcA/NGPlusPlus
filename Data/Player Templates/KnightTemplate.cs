using RPGGame.Abilities;
using RPGGame.Enums;
using RPGGame.Interfaces;
using System.Collections.Generic;

namespace RPGGame.Data
{
    public class KnightTemplate: IPlayerTemplate
    {
        public KnightTemplate(int level) 
        {
            ExperienceNeeded = 50 * level;
            MaxHealth = 50 * level;
            MaxMana = 5 * level;
            Attack = 8 * level; 
            Defense = 10 * level;
            MagicAttack = 5 * level;
            MagicDefense = 8 * level;
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
        public List<IAbility> Abilities { get; private set;  }

        private void AbilityShop(int level)
        {
            Abilities.Add(new Damage("Attack", TargetType.Other, DamageType.Physical, 0, 1 * level, 1 * level));
            Abilities.Add(new Buff("Defense Up", TargetType.Self, StatType.Defense, 2 * level, 3 * level));

            if (level >= 3)
            {
                Abilities.Add(new Heal("Heal Self", TargetType.Self, 3 * level, 25 * level));
            }

            if (level >= 5)
            {
                Abilities.Add(new Damage("Heavy Swing", TargetType.Other, DamageType.Physical, 3 * level, 3 * level, 5 * level));
            }

            if (level >= 9)
            {
                Abilities.Add(new Damage("Spear Wall", TargetType.OtherAll, DamageType.Physical, 4 * level, 5 * level, 8 * level));
            }
        }
    }
}

