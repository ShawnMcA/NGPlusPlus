using NGPlusPlus.Data;
using NGPlusPlus.Enums;
using NGPlusPlus.Interfaces;

namespace NGPlusPlus.EnemyNameSpace
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
