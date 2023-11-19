using RPGGame.Abilities;
using RPGGame.Enums;
using RPGGame.Interfaces;
using System.Collections.Generic;

namespace RPGGame.Data {
    public class RatTemplate : IEnemyTemplate 
    {
        public RatTemplate(int level)
        {
            ExperienceGiven = 5 * level;
            MaxHealth = 20 * level; 
            Attack = 5 * level;
            Defense = 5 * level;
            MagicAttack = 5 * level;
            MagicDefense = 5 * level;
            Speed = 5 * level;
            Abilities = new List<IAbility>();

            AbilityShop(level);
        }
        public int ExperienceGiven { get; }
        public int MaxHealth { get; }
        public int Attack { get; }
        public int Defense { get; }
        public int MagicAttack { get; }
        public int MagicDefense { get; }
        public int Speed { get; }
        public List<IAbility> Abilities { get; private set; }

        private void AbilityShop(int level)
        {
            Abilities.Add(new Damage("Attack", TargetType.Other, DamageType.Physical, 0, level, level));
            Abilities.Add(new Damage("Strong Bite", TargetType.Other, DamageType.Physical, 0, level * 2, level * 2));
        }
    }

}