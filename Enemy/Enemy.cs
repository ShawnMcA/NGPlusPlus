using NGPlusPlus.Core;
using NGPlusPlus.Data;
using NGPlusPlus.EnemyNameSpace;
using NGPlusPlus.Enums;
using NGPlusPlus.Interfaces;

namespace NGPlusPlus.EnemyNamespace
{
    public class Enemy : ICreature
    {
        public Enemy(EnemyType type, string name, int level) 
        {
            Type = type;
            Level = level;
            Name = name;
            InitializeEnemy();
        }

        #region "Properties"
        public Guid Guid { get; private set; }

        public CreatureType CreatureType => CreatureType.Enemy;
        public EnemyType Type { get; set; } // Update in editor
        public string Name { get; set; } // Update in editor
        public int Level { get; set; } // Update in editor
        public int ExperienceGiven { get; private set; }
        public IStats Stats { get; private set; }
        public List<IAbility> Abilities { get; private set; }

        #endregion "Properties"

        #region "Saving/Loading"
        private void InitializeEnemy()
        {
            var template = TemplateManager.GetEnemyTemplate(Type, Level);

            Guid = Guid.NewGuid();
            ExperienceGiven = template.ExperienceGiven;
            Stats = template.Stats;
            Abilities = template.Abilities;

            ResetStats();
        }
        #endregion "Saving/Loading"

        #region "Battling"
        public int CalculateSpeed()
        {
            Random rnd = new Random();
            return rnd.Next(Stats.Speed.Current * 1, Stats.Speed.Current * 2);
        }

        public int CalculatePhysicalDamage(int rangeLow, int rangeHigh)
        {
            Random rnd = new Random();
            return rnd.Next((Stats.Attack.Current + rangeLow) * 1, (Stats.Attack.Current + rangeHigh));
        }

        public int CalculateMagicDamage(int rangeLow, int rangeHigh)
        {
            Random rnd = new Random();
            return rnd.Next((Stats.MagicAttack.Current + rangeLow) * 1, (Stats.MagicAttack.Current + rangeHigh));
        }

        public void Defend()
        {
            Stats.Defense.Current = (int)Math.Ceiling(Stats.Defense.Max * 1.1);
            Stats.Defense.Current = (int)Math.Ceiling(Stats.Defense.Max * 1.1);
        }

        public void TakePhysicalDamage(int enemyAttack)
        {
            var damage = enemyAttack - (Stats.Defense.Current); // Can change to more complex calculation

            if (damage < 0)
                damage = 0;

            TextLogger.ClearWriteTextAndWait($"{Name} blocks {enemyAttack - damage} damage and takes {damage}.");

            Stats.Health.Current -= damage;

            if (Stats.Health.Current < 0)
            {
                Stats.Health.Current = 0;
            }
        }

        public void TakeMagicDamage(int enemyAttack)
        {
            var damage = enemyAttack - (Stats.MagicDefense.Current * 2); // Can change to more complex calculation

            if (damage < 0)
                damage = 0;

            TextLogger.ClearWriteTextAndWait($"{Name} blocks {enemyAttack - damage} damage and takes {damage}.");

            Stats.Health.Current -= damage;

            if (Stats.Health.Current < 0)
            {
                Stats.Health.Current = 0;
            }
        }

        public void BuffStat(StatType statType, int amount)
        {
            switch (statType)
            {
                case StatType.Attack:
                    Stats.Attack.Current += amount;
                    if (Stats.Attack.Current < 1)
                        Stats.Attack.Current = 1;
                    break;

                case StatType.Defense:
                    Stats.Defense.Current += amount;
                    if (Stats.Defense.Current < 1)
                        Stats.Defense.Current = 1;
                    break;

                case StatType.MagicAttack:
                    Stats.MagicAttack.Current += amount;
                    if (Stats.MagicAttack.Current < 1)
                        Stats.MagicAttack.Current = 1;
                    break;

                case StatType.MagicDefense:
                    Stats.MagicDefense.Current += amount;
                    if (Stats.MagicDefense.Current < 1)
                        Stats.MagicDefense.Current = 1;
                    break;

                case StatType.Speed:
                    Stats.Speed.Current += amount;
                    if (Stats.Speed.Current < 1)
                        Stats.Speed.Current = 1;
                    break;
            }
        }

        public void RestoreHealth(int healthGained)
        {
            Stats.Health.Current += healthGained;

            if (Stats.Health.Current > Stats.Health.Max)
                Stats.Health.Current = Stats.Health.Max;
        }

        public void ResetStats()
        {
            Stats.Attack.Current = Stats.Attack.Max;
            Stats.Defense.Current = Stats.Defense.Max;
            Stats.MagicAttack.Current = Stats.MagicAttack.Max;
            Stats.MagicDefense.Current = Stats.MagicDefense.Max;
            Stats.Speed.Current = Stats.Speed.Max;
        }

        public IAbility PickAbility()
        {
            var length = Abilities.Count;
            Random rnd = new Random();

            return Abilities[rnd.Next(0, length)];
        }
        #endregion "Battling"
    }
}
