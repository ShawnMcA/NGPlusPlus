using NGPlusPlus.Enums;
using NGPlusPlus.StatsNamespace;
using System.Collections.Generic;

namespace NGPlusPlus.Interfaces
{
    public interface ICreature
    {
        public CreatureType CreatureType { get; }
        public string Name { get; }
        public IStats Stats { get; }
        public List<IAbility> Abilities { get; }
        public void Defend();
        public int CalculateSpeed();
        public int CalculatePhysicalDamage(int rangeLow, int rangeHigh);

        public int CalculateMagicDamage(int rangeLow, int rangeHigh);

        public void TakePhysicalDamage(int enemyAttack);
        public void TakeMagicDamage(int enemyAttack);

        public void RestoreHealth(int healthGained);
        public void ResetStats();

        public void BuffStat(StatType statType, int amount);
        public IAbility PickAbility();
    }
}
