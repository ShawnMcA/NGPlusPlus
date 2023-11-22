using NGPlusPlus.Interfaces;

namespace NGPlusPlus.StatsNamespace
{
    public class Stat : IStat
    {
        public Stat(int value) 
        {
            Current = value;
            Max = value;
        }

        public int Current { get; set; }
        public int Max { get; set; }
    }
}
