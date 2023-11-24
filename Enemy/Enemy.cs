using NGPlusPlus.Abilities;
using NGPlusPlus.BattleCalculatorNamespace;
using NGPlusPlus.Core;
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
        public EnemyType Type { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int ExperienceGiven { get; private set; }
        public IStats Stats { get; private set; }
        public List<IAbility> Abilities { get; private set; }

        #endregion "Properties"

        #region "Saving/Loading"
        private void InitializeEnemy()
        {
            var template = EnemyTemplateManager.GetEnemyTemplate(Type, Level);

            Guid = Guid.NewGuid();
            ExperienceGiven = template.ExperienceGiven;
            Stats = template.Stats;
            Abilities = template.Abilities;
        }
        #endregion "Saving/Loading"

        #region "Battling"
        public int CalculateBattleSpeed()
        {
            return BattleCalculator.CalculateSpeed(Stats.Speed.Current);
        }

        public int CalculateDamageOutput(int rangeLow, int rangeHigh, DamageType damageType)
        {
            return BattleCalculator.CalculateDamageOutput(rangeLow,
                rangeHigh,
                damageType == DamageType.Physical ? Stats.Attack.Current : Stats.MagicAttack.Current
            );
        }

        public void TakeDamage(int enemyAttack, DamageType damageType)
        {
            var damage = BattleCalculator.CalculateDamageInput(enemyAttack,
                damageType == DamageType.Physical ? Stats.Defense.Current : Stats.MagicDefense.Current
            );

            TextLogger.ClearWriteTextAndWait($"{Name} blocks {enemyAttack - damage} damage and takes {damage}.");

            Stats.Health.Current -= damage;

            if (Stats.Health.Current < 0)
            {
                Stats.Health.Current = 0;
            }
        }

        public void Defend()
        {
            Stats.Defense.Current = (int)Math.Ceiling(Stats.Defense.Max * 1.1);
            Stats.Defense.Current = (int)Math.Ceiling(Stats.Defense.Max * 1.1);
        }

        public IAbility PickAbility()
        {
            Random rnd = new Random();

            var ability = -1;
            var validChoice = false;

            do
            {
                ability = rnd.Next(0, Abilities.Count);
                validChoice = CheckIsValidAbility(ability);

            } while (!validChoice);

            return Abilities[ability];
        }

        public void SpendMana(int manaSpent)
        {
            Stats.Mana.Current -= manaSpent;

            if (Stats.Mana.Current < 0)
                Stats.Mana.Current = 0;
        }

        private bool CheckIsValidAbility(int ability) 
        {
            var isValid = HasManaForAbility(ability);

            if (isValid)
                isValid = !IsHealWithFullHealth(ability);

            return isValid;
        }

        private bool IsHealWithFullHealth(int ability)
        {
            return Stats.IsFullHealth() && Abilities[ability].AbilityType == AbilityType.Heal;
        }

        private bool HasManaForAbility(int ability)
        {
            var isValid = Abilities[ability].ManaCost <= Stats.Mana.Current;

            return isValid;
        }

        #endregion "Battling"
    }
}
