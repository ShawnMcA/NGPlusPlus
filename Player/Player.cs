using NGPlusPlus.Core;
using NGPlusPlus.Enums;
using NGPlusPlus.Interfaces;

namespace NGPlusPlus.PlayerNameSpace
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

        public CreatureType CreatureType => CreatureType.Player;
        public string Name { get; private set; }
        public PlayerClass Class { get; private set; } = PlayerClass.Knight;
        public int Experience { get; set; }
        public int ExperienceNeeded { get; set; }
        public IStats Stats { get; private set; }
        public List<IAbility> Abilities { get; private set; }

        #endregion "Properties"

        #region "Saving/Loading"
        public void InitializePlayer(string name, PlayerClass playerClass)
        {
            if (!string.IsNullOrEmpty(Name)) // Player already initialized
                return;

            Name = name;
            SetClass(playerClass);
        }

        public void ResetPlayer()
        {
            Name = null;
        }

        public void SetClass(PlayerClass playerClass) 
        {
            Class = playerClass;

            var template = TemplateManager.GetPlayerTemplate(Class, 1);

            Stats = template.Stats;
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
            Stats.Level += 1;

            var template = TemplateManager.GetPlayerTemplate(Class, Stats.Level);

            ExperienceNeeded = template.ExperienceNeeded;
            Stats = template.Stats;
            Abilities = template.Abilities;
        }
        #endregion "Experience/Levels"

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

        public void TakePhysicalDamage(int enemyAttack)
        {
            var damage = enemyAttack - (Stats.Defense.Current); // Can change to more complex calculation

            if (damage < 0) damage = 0;

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

            if (damage < 0) damage = 0;

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

        public void RestoreMana(int manaGained)
        {
            Stats.Mana.Current += manaGained;

            if (Stats.Mana.Current > Stats.Mana.Max)
                Stats.Mana.Current = Stats.Mana.Max;
        }

        public void ResetHealthAndMana() 
        {
            Stats.Health.Current = Stats.Health.Max;
            Stats.Mana.Current = Stats.Mana.Max;
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
            int ability = 9999;

            do
            {
                TextLogger.ClearWriteText("Choose an ability...");
                Int32.TryParse(Console.ReadLine(), out ability);
            } while (ability <= 0 || ability > Abilities.Count);

            return Abilities[ability - 1];
        }
        #endregion "Battling"
    }
}
