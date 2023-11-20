using RPGGame.Core;
using RPGGame.Data;
using RPGGame.Enums;
using RPGGame.Interfaces;
using RPGGame.PlayerNameSpace;
using System;
using System.Collections.Generic;

namespace RPGGame.PlayerNameSpace
{
    public sealed class Player : ICreature
    {
        private Player() { }
        private static Player Instance;
        public static Player GetInstance() 
        { 
            if(Instance == null) 
            {
                Instance = new Player();
            }

            return Instance;
        }

        #region "Properties"
        public string Name { get; private set; }
        public PlayerClass Class { get; private set; } = PlayerClass.Archer;
        public int Level { get; private set; }
        public int Experience { get; private set; }
        public int ExperienceNeeded { get; private set; }
        public int MaxHealth { get; private set; }
        public int CurrentHealth { get; private set; }
        public int MaxMana { get; private set; }
        public int CurrentMana { get; private set; }
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
        public void InitializePlayer(string name)
        {
            if (!string.IsNullOrEmpty(Name)) // Player already initialized
                return;

            Name = name;
            SetClass(Class);
        }

        public void ResetPlayer()
        {
            Name = null;
        }

        public void SetClass(PlayerClass playerClass) 
        {
            Class = playerClass;

            var template = TemplateManager.GetPlayerTemplate(Class, 1);

            Level = 1;
            Experience = 0;
            ExperienceNeeded = template.ExperienceNeeded;
            MaxHealth = template.MaxHealth;
            CurrentHealth = MaxHealth;
            MaxMana= template.MaxMana;
            CurrentMana = MaxMana;
            Attack = template.Attack;
            CurrentAttack = Attack;
            Defense = template.Defense;
            CurrentDefense = Defense;
            MagicAttack = template.MagicAttack;
            CurrentMagicAttack = MagicAttack;
            MagicDefense = template.MagicDefense;
            CurrentMagicDefense = MagicDefense;
            Speed = template.Speed;
            CurrentSpeed = Speed;
            Abilities = template.Abilities;
        }
        #endregion "Saving/Loading"

        #region "Experience/Levels"
        public void GainExperience(int experience)
        {
            Experience += experience;
             
            if (Experience >= ExperienceNeeded) LevelUp();
        }

        private void LevelUp() 
        {
            Level += 1;

            var template = TemplateManager.GetPlayerTemplate(Class, Level);

            ExperienceNeeded = template.ExperienceNeeded;
            MaxHealth = template.MaxHealth;
            CurrentHealth = MaxHealth;
            MaxMana = template.MaxMana;
            CurrentMana= MaxMana;
            Attack = template.Attack;
            Defense = template.Defense;
            MagicAttack = template.MagicAttack;
            MagicDefense = template.MagicDefense;
            Speed = template.Speed;
            Abilities = template.Abilities;
        }
        #endregion "Experience/Levels"

        #region "Battling"
        
        public int CalculateSpeed() 
        {
            Random rnd = new Random();
            return rnd.Next(CurrentSpeed * 1, CurrentSpeed * 2);
        }

        public int CalculatePhysicalDamage(int rangeLow, int rangeHigh) 
        {
            Random rnd = new Random();
            return rnd.Next((CurrentAttack + rangeLow) * 1, (CurrentAttack + rangeHigh));
        }

        public int CalculateMagicDamage(int rangeLow, int rangeHigh)
        {
            Random rnd = new Random();
            return rnd.Next((CurrentMagicAttack + rangeLow) * 1, (CurrentMagicAttack + rangeHigh));
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
        public void Defend() 
        {
            CurrentDefense = (int)Math.Ceiling(Defense * 1.1);
            CurrentMagicDefense = (int)Math.Ceiling(MagicDefense * 1.1);
        }

        public void BuffStat(StatType statType, int amount)
        {
            switch (statType)
            {
                case StatType.Attack:
                    CurrentAttack += amount;

                    if (CurrentAttack < 1) CurrentAttack = 1;

                    break;
                case StatType.Defense:
                    CurrentDefense += amount;
                    if (CurrentDefense < 1) CurrentDefense = 1;

                    break;
                case StatType.MagicAttack:
                    CurrentMagicAttack += amount;

                    if (CurrentMagicAttack < 1) CurrentMagicAttack = 1;

                    break;
                case StatType.MagicDefense:
                    CurrentMagicDefense += amount;

                    if (CurrentMagicDefense < 1) CurrentMagicDefense = 1;

                    break;
                case StatType.Speed:
                    CurrentSpeed += amount;

                    if (CurrentSpeed < 1) CurrentSpeed = 1;

                    break;
            }
        }

        public void RestoreHealth(int healthGained) 
        {
            CurrentHealth += healthGained;

            if (CurrentHealth > MaxHealth) CurrentHealth = MaxHealth;
        }

        public void RestoreMana(int manaGained)
        {
            CurrentMana += manaGained;

            if (CurrentMana > MaxMana) CurrentMana = MaxMana;
        }

        public void ResetHealthAndMana() 
        {
            CurrentHealth = MaxHealth;
            CurrentMana = MaxMana;
        }

        public void ResetStats() 
        {
            CurrentAttack = Attack;
            CurrentDefense = Defense;
            CurrentMagicAttack = MagicAttack;
            CurrentMagicDefense = MagicDefense;
            CurrentSpeed = Speed;
        }
        #endregion "Battling"
    }
}
