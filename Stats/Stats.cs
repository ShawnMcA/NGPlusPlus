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
    }
}
