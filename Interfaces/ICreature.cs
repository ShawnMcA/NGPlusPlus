using RPGGame.Enums;
using System.Collections.Generic;

namespace RPGGame.Interfaces
{
    public interface ICreature
    {
        public string Name { get; }
        public int Level { get; }
        public int MaxHealth { get; }
        public int CurrentHealth { get; }
        public int Attack { get; }
        public int CurrentAttack { get; }
        public int Defense { get; }
        public int CurrentDefense { get; }
        public int MagicAttack { get; }
        public int CurrentMagicAttack { get; }
        public int MagicDefense { get; }
        public int CurrentMagicDefense { get; }
        public int Speed { get; }
        public int CurrentSpeed { get; }
        public List<IAbility> Abilities { get; }

        public bool IsDead();
        public void Defend();
        public int CalculateSpeed();
        public int CalculatePhysicalDamage(int rangeLow, int rangeHigh);

        public int CalculateMagicDamage(int rangeLow, int rangeHigh);

        public void TakePhysicalDamage(int enemyAttack);
        public void TakeMagicDamage(int enemyAttack);

        public void RestoreHealth(int healthGained);
        public void ResetStats();

        public void BuffStat(StatType statType, int amount);
    }
}
