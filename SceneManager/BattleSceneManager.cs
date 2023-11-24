using NGPlusPlus.Core;
using NGPlusPlus.EnemyNamespace;
using NGPlusPlus.Enums;
using NGPlusPlus.GameScreensNamespace;
using NGPlusPlus.PlayerNameSpace;
using NGPlusPlus.ScreenRendererNamespace;
using NGPlusPlus.BattleManagerNamespace;
using NGPlusPlus.Interfaces;
using NGPlusPlus.EnemyNameSpace;

namespace NGPlusPlus.SceneManagerNamespace
{
    internal static class BattleSceneManager
    {
        public static bool StartBattle(EnemyType enemyType, 
            string enemyName, 
            int enemyLevel,
            bool isAmbushed
            ) 
        { 
            var enemy = new Enemy(enemyType, enemyName, enemyLevel);
            var screen = EnemyTemplateManager.GetEnemyGameScreen(enemy);

            var battleManager = new BattleManager(enemy, screen, isAmbushed);

            return battleManager.StartCoreLoop();
        }

        public static void PlayBattleWon()
        {
            var battleWon = new BattleWon();
            ScreenRenderer.RenderAnimation(battleWon);

            var player = Player.GetInstance();
            player.ResetPlayer();
        }

        public static void PlayGameOver()
        {
            var gameOver = new GameOver();

            ScreenRenderer.RenderAnimation(gameOver);

            TextLogger.ClearWriteTextAndWait("Ohh no... It seems you're no longer with us. It was fun while it lasted...");

            var player = Player.GetInstance();
            player.ResetPlayer();
        }
    }
}
