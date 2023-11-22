using NGPlusPlus.StatsNamespace;
using System.Collections.Generic;

namespace NGPlusPlus.Interfaces
{
    public interface IPlayerTemplate {
        int ExperienceNeeded { get; }
        IStats Stats { get; }
        List<IAbility> Abilities { get; }
    }
}
