using NGPlusPlus.Core;
using NGPlusPlus.EnemyNamespace;
using NGPlusPlus.Enums;
using NGPlusPlus.GameScreensNamespace;
using NGPlusPlus.PlayerNameSpace;
using NGPlusPlus.ScreenRendererNamespace;
using NGPlusPlus.BattleManagerNamespace;
using NGPlusPlus.EnemyNameSpace;
using NGPlusPlus.Interfaces;
using NGPlusPlus.MiscClasses;
using System.Numerics;

namespace NGPlusPlus.SceneManagerNamespace
{
    internal static class BattleSceneManager
    {
        public static bool StartBattle(EnemyType enemyType, 
            string name, 
            int level,
            bool isAmbushed
            ) 
        {
            var enemyPackage = EnemyTemplateManager.GenerateEnemyPackage(enemyType, name, level);

            BattleScreenRenderer.RenderFightScreen(enemyPackage.EnemyScreen);

            var battleManager = new BattleManager(enemyPackage, isAmbushed);

            var battleWon = battleManager.StartCoreLoop();

            HandleBattleWon(battleWon, enemyPackage);

            return battleWon;
        }

        public static void RerenderEnemy(EnemyPackage enemyPackage)
        {
            BattleScreenRenderer.RenderEnemyAnimation(enemyPackage.EnemyScreen);
        }

        public static void RerenderStats()
        {
            BattleScreenRenderer.RenderStatBox();
        }

        public static void PlayBattleWon(EnemyPackage enemyPackage)
        {
            var battleWon = new BattleWonScreen();
            ScreenRenderer.RenderAnimation(battleWon);
            TextLogger.ClearWriteTextAndWait($"You've managed to defeat {enemyPackage.Enemy.Name} and gained {enemyPackage.Enemy.ExperienceGiven} experience.");

            var player = Player.GetInstance();
            player.GainExperience(enemyPackage.Enemy.ExperienceGiven);
        }

        public static void PlayGameOver()
        {
            var gameOver = new GameOverScreen();

            ScreenRenderer.RenderAnimation(gameOver);

            TextLogger.ClearWriteTextAndWait("Ohh no... It seems you're no longer with us. It was fun while it lasted...");

            var player = Player.GetInstance();
            player.ResetPlayer();
        }
        public static void HandleBattleWon(bool battleWon, EnemyPackage enemyPackage)
        {
            if (battleWon)
                PlayBattleWon(enemyPackage);
            else
                PlayGameOver();
        }
    }
}
