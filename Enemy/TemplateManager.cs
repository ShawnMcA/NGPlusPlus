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
                EnemyType.Rat => new Rat(level),
                EnemyType.Spider => new Spider(level),
                _ => new Rat(level)
            };
        }
    }
}
