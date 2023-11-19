using RPGGame.Core;
using RPGGame.Data;
using RPGGame.EnemyNameSpace;
using RPGGame.Enums;
using RPGGame.Interfaces;

namespace RPGGame.EnemyNamespace
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
        public EnemyType Type { get; set; } // Update in editor
        public string Name { get; set; } // Update in editor
        public int Level { get; set; } // Update in editor
        public int ExperienceGiven { get; private set; }
        public int MaxHealth { get; private set; }
        public int CurrentHealth { get; private set; }
        public int Attack { get; private set; }
        public int CurrentAttack { get; private set; }
        public int Defense { get; private set; }
        public int CurrentDefense { get; private set; }
        public int MagicAttack { get; private set; }
        public int CurrentMagicAttack { get; private set; }
        public int MagicDefense { get; private set; }
        public int CurrentMagicDefense { get; private set; }
        public int Speed { get; private set; }
        public int CurrentSpeed { get; private set; }
        public List<IAbility> Abilities { get; private set; }
        public bool IsDead() => CurrentHealth <= 0;

        #endregion "Properties"

        #region "Saving/Loading"
        private void InitializeEnemy()
        {
            var template = TemplateManager.GetEnemyTemplate(Type, Level);

            Guid = Guid.NewGuid();
            ExperienceGiven = template.ExperienceGiven;
            MaxHealth = template.MaxHealth;
            CurrentHealth = MaxHealth;
            Attack = template.Attack;
            Defense = template.Defense;
            MagicAttack = template.MagicAttack;
            MagicDefense = template.MagicDefense;
            Speed = template.Speed;
            Abilities = template.Abilities;

            ResetStats();
        }
        #endregion "Saving/Loading"

        #region "Battling"
        public int CalculateSpeed() {
            Random rnd = new Random();
            return rnd.Next(CurrentSpeed * 1, CurrentSpeed * 2);
        }

        public int CalculatePhysicalDamage(int rangeLow, int rangeHigh)
        {
            Random rnd = new Random();
            return rnd.Next((CurrentAttack + rangeLow), (CurrentAttack + rangeHigh));
        }

        public int CalculateMagicDamage(int rangeLow, int rangeHigh)
        {
            Random rnd = new Random();
            return rnd.Next((CurrentMagicAttack + rangeLow), (CurrentMagicAttack + rangeHigh));
        }

        public void Defend()
        {
            CurrentDefense = (int)Math.Ceiling(Defense * 1.1);
            CurrentMagicDefense = (int)Math.Ceiling(MagicDefense * 1.1);
        }

        public void TakePhysicalDamage(int enemyAttack)
        {
            var damage = enemyAttack - (CurrentDefense); // Can change to more complex calculation

            if (damage < 0) damage = 0;

            TextLogger.ClearWriteTextAndWait($"{Name} blocks {enemyAttack - damage} damage and takes {damage}.");

            CurrentHealth -= damage;

            if (CurrentHealth < 0)
            {
                CurrentHealth = 0;
            }
        }

        public void TakeMagicDamage(int enemyAttack)
        {
            var damage = enemyAttack - (CurrentMagicDefense * 2); // Can change to more complex calculation

            if (damage < 0) damage = 0;

            TextLogger.ClearWriteTextAndWait($"{Name} blocks {enemyAttack - damage} damage and takes {damage}.");

            CurrentHealth -= damage;

            if (CurrentHealth < 0)
            {
                CurrentHealth = 0;
            }
        }
        public void BuffStat(StatType statType, int amount)
        {
            switch (statType)
            {
                case StatType.Attack:
                    CurrentAttack += amount;

                    if (CurrentAttack < 1)
                        CurrentAttack = 1;

                    break;
                case StatType.Defense:
                    CurrentDefense += amount;
                    if (CurrentDefense < 1)
                        CurrentDefense = 1;

                    break;
                case StatType.MagicAttack:
                    CurrentMagicAttack += amount;

                    if (CurrentMagicAttack < 1)
                        CurrentMagicAttack = 1;

                    break;
                case StatType.MagicDefense:
                    CurrentMagicDefense += amount;

                    if (CurrentMagicDefense < 1)
                        CurrentMagicDefense = 1;

                    break;
                case StatType.Speed:
                    CurrentSpeed += amount;

                    if (CurrentSpeed < 1)
                        CurrentSpeed = 1;

                    break;
            }
        }

        public void RestoreHealth(int healthGained) 
        {
            CurrentHealth += healthGained;

            if (CurrentHealth > MaxHealth) CurrentHealth = MaxHealth;
        }

        public void ResetStats() 
        {
            CurrentAttack = Attack;
            CurrentDefense = Defense;
            CurrentMagicAttack = MagicAttack;
            CurrentMagicDefense = MagicDefense;
            CurrentSpeed = Speed;
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
