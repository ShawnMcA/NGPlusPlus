using NGPlusPlus.Enums;
using NGPlusPlus.Interfaces;

namespace NGPlusPlus.StatsNamespace
{
    public class Stats : IStats
    {
        public Stats(int level,
            int health,
            int mana,
            int attack,
            int defense,
            int magicAttack,
            int magicDefense,
            int speed)
        {
            Level = level;
            Health = new Stat(health);
            Mana = new Stat(mana);
            Attack = new Stat(attack);
            Defense = new Stat(defense);
            MagicAttack = new Stat(magicAttack);
            MagicDefense = new Stat(magicDefense);
            Speed = new Stat(speed);
        }

        public int Level { get; set; }
        public IStat Health { get; set; }
        public IStat Mana { get; set; }
        public IStat Attack { get; set; }
        public IStat Defense { get; set; }
        public IStat MagicAttack { get; set; }
        public IStat MagicDefense { get; set; }
        public IStat Speed { get; set; }
        public bool IsDead() => Health.Current <= 0;

        public void RestoreHealth(int healthGained) 
        {
            Health.Current += healthGained;

            if (Health.Current > Health.Max)
                Health.Current = Health.Max;
        }

        public void RestoreMana(int manaGained)
        {
            Mana.Current += manaGained;

            if (Mana.Current > Mana.Max)
                Mana.Current = Mana.Max;
        }

        public void BuffStat(StatType statType, int amount)
        {
            switch (statType)
            {
                case StatType.Attack:
                    Attack.Current += amount;
                    if (Attack.Current < 0)
                        Attack.Current = 0;
                    break;

                case StatType.Defense:
                    Defense.Current += amount;
                    if (Defense.Current < 0)
                        Defense.Current = 0;
                    break;

                case StatType.MagicAttack:
                    MagicAttack.Current += amount;
                    if (MagicAttack.Current < 0)
                        MagicAttack.Current = 0;
                    break;

                case StatType.MagicDefense:
                    MagicDefense.Current += amount;
                    if (MagicDefense.Current < 0)
                        MagicDefense.Current = 0;
                    break;

                case StatType.Speed:
                    Speed.Current += amount;
                    if (Speed.Current < 0)
                        Speed.Current = 0;
                    break;
            }
        }

        public void IncrementalStatRestore() 
        {
            RestoreFractionOfMax(Mana, 5);
            RestoreFractionOfMax(Attack, 5);
            RestoreFractionOfMax(Defense, 5);
            RestoreFractionOfMax(MagicAttack, 5);
            RestoreFractionOfMax(MagicDefense, 5);
            RestoreFractionOfMax(Speed, 5);
        }

        public void ResetHealthAndMana() 
        {
            Health.Current = Health.Max;
            Mana.Current = Mana.Max;
        }

        public void ResetStat(StatType type) 
        {
            switch (type)
            {
                case StatType.Health: 
                    Health.Current = Health.Max;
                    break;
                case StatType.Mana:
                    Mana.Current = Mana.Max;
                    break;
                case StatType.Attack:
                    Attack.Current = Attack.Max;
                    break;
                case StatType.Defense:
                    Defense.Current = Defense.Max;
                    break;
                case StatType.MagicAttack:
                    MagicAttack.Current = MagicAttack.Max;
                    break;
                case StatType.MagicDefense:
                    MagicDefense.Current = MagicDefense.Max;
                    break;
                case StatType.Speed:
                    Speed.Current = Speed.Max;
                    break;
            } 
        }

        public void ResetAll()
        {
            Health.Current = Health.Max;
            Mana.Current = Mana.Max;
            Attack.Current = Attack.Max;
            Defense.Current = Defense.Max;
            MagicAttack.Current = MagicAttack.Max;
            MagicDefense.Current = MagicDefense.Max;
            Speed.Current = Speed.Max;
        }

        private void RestoreFractionOfMax(IStat stat, int fraction) 
        {
            if (stat.Current == stat.Max)
                return;

            int amountToRestore = (int)Math.Ceiling((double)stat.Max / fraction);

            if(stat.Current > stat.Max)
            {
                stat.Current -= amountToRestore;

                if (stat.Current < stat.Max)
                    stat.Current = stat.Max;
            }
            else
            {
                stat.Current += amountToRestore;

                if (stat.Current > stat.Max)
                    stat.Current = stat.Max;
            }
        }
    }
}
