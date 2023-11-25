using NGPlusPlus.Data;
using NGPlusPlus.EnemyNamespace;
using NGPlusPlus.Enums;
using NGPlusPlus.GameScreens.Enemies;
using NGPlusPlus.GameScreensNamespace;
using NGPlusPlus.Interfaces;
using NGPlusPlus.MiscClasses;

namespace NGPlusPlus.EnemyNameSpace
{
    public static class EnemyTemplateManager
    {
        public static EnemyPackage GenerateEnemyPackage(EnemyType enemyType, string name, int level)
        {
            var enemyTemplate = GetEnemyTemplate(enemyType, level);
            var enemy = new Enemy(enemyType, enemyTemplate, name, level);
            var gameScreen = GetEnemyGameScreen(enemy);

            return new EnemyPackage
            {
                Enemy = enemy,
                EnemyScreen = gameScreen
            };
        }

        private static IEnemyTemplate GetEnemyTemplate(EnemyType enemyType, int level) 
        {
            return enemyType switch
            {
                EnemyType.Rat => new RatTemplate(level),
                EnemyType.Spider => new SpiderTemplate(level),
                EnemyType.Snake => new SnakeTemplate(level),
                _ => new RatTemplate(level)
            };
        }

        private static IGameScreen GetEnemyGameScreen(Enemy enemy)
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
