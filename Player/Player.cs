using NGPlusPlus.BattleCalculatorNamespace;
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
            if (Instance == null)
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

        #region "Initialization"
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

        public int CalculateBattleSpeed(){
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
            Stats.MagicDefense.Current = (int)Math.Ceiling(Stats.MagicDefense.Max * 1.1);
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
