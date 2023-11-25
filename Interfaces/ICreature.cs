using NGPlusPlus.BattleCalculatorNamespace;
using NGPlusPlus.Core;
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
        public int CalculateBattleSpeed();
        public int CalculateDamageOutput(int baseDamage, int accuracy, DamageType damageType);

        public void TakeDamage(int enemyAttack, DamageType damageType);

        public IAbility PickAbility();

        public void SpendMana(int manaSpent);
    }
}
