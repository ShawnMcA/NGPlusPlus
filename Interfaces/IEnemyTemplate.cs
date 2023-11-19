using System.Collections.Generic;

namespace RPGGame.Interfaces
{
    public interface IEnemyTemplate {
        int ExperienceGiven { get; }
        int MaxHealth { get; }
        int Attack { get; }
        int Defense { get; }
        int MagicAttack { get; }
        int MagicDefense { get; }
        int Speed { get; }
        List<IAbility> Abilities { get; }
    }
}
