using RPGGame.Abilities;
using RPGGame.Enums;
using RPGGame.Interfaces;
using System.Collections.Generic;

namespace RPGGame.Data
{
    public class ArcherTemplate: IPlayerTemplate
    {
        public ArcherTemplate(int level) 
        {
            ExperienceNeeded = 50 * level;
            MaxHealth = 40 * level;
            MaxMana = 7 * level;
            Attack = 10 * level;
            Defense = 7 * level;
            MagicAttack = 5 * level;
            MagicDefense = 5 * level;
            Speed = 10 * level;
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
            Abilities.Add(new Damage("Quick Shot", TargetType.Other, DamageType.Physical, 3 * level, 1 * level, 3 * level));

            if (level >= 3)
            {
                Abilities.Add(new Heal("Heal Self", TargetType.Self, 3 * level, 15 * level));
            }

            if (level >= 5)
            {
                Abilities.Add(new Buff("Attack Up", TargetType.Self, StatType.Attack, 3 * level, 3 * level));
            }

            if (level >= 9)
            {
                Abilities.Add(new Damage("Ohh Hail No", TargetType.OtherAll, DamageType.Physical, 5 * level, 5 * level, 8 * level));
            }
        }
    }
}

