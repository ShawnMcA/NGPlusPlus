using System.Collections.Generic;

namespace RPGGame.Interfaces
{
    public interface IPlayerTemplate {
        int ExperienceNeeded { get; }
        int MaxHealth { get; }
        int MaxMana { get; }
        int Attack { get; }
        int Defense { get; }
        int MagicAttack { get; }
        int MagicDefense { get; }
        int Speed { get; }
        List<IAbility> Abilities { get; }
    }
}
