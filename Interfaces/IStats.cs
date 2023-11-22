using NGPlusPlus.Enums;

namespace NGPlusPlus.Interfaces
{
    public interface IStats
    {
        public int Level { get; set; }
        public IStat Health { get; set; }
        public IStat Mana { get; set; }
        public IStat Attack { get; set; }
        public IStat Defense { get; set; }
        public IStat MagicAttack { get; set; }
        public IStat MagicDefense { get; set; }
        public IStat Speed { get; set; }
        public bool IsDead();
        public void ResetHealthAndMana();
        public void ResetStat(StatType type);
        public void ResetAll();
    }
}
