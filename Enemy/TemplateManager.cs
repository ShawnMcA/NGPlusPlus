using RPGGame.Data;
using RPGGame.Enums;
using RPGGame.Interfaces;

namespace RPGGame.EnemyNameSpace
{
    public static class TemplateManager
    {
        public static IEnemyTemplate GetEnemyTemplate(EnemyType enemyType, int level) 
        {
            return enemyType switch
            {
                EnemyType.Rat => new RatTemplate(level),
                _ => new RatTemplate(level)
            };
        }
    }
}
