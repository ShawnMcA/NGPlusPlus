using NGPlusPlus.Data;
using NGPlusPlus.EnemyNamespace;
using NGPlusPlus.Enums;
using NGPlusPlus.GameScreens.Enemies;
using NGPlusPlus.GameScreensNamespace;
using NGPlusPlus.Interfaces;
using System.Reflection.Emit;

namespace NGPlusPlus.EnemyNameSpace
{
    public static class EnemyTemplateManager
    {
        public static IEnemyTemplate GetEnemyTemplate(EnemyType enemyType, int level) 
        {
            return enemyType switch
            {
                EnemyType.Rat => new Rat(level),
                EnemyType.Spider => new Spider(level),
                EnemyType.Snake => new Snake(level),
                _ => new Rat(level)
            };
        }

        public static IGameScreen GetEnemyGameScreen(Enemy enemy)
        {
            return enemy.Type switch
            {
                EnemyType.Rat => new RatScreen(enemy),
                EnemyType.Spider => new SpiderScreen(enemy),
                EnemyType.Snake => new SnakeScreen(enemy),
                _ => new RatScreen(enemy)
            };
        }
    }
}
