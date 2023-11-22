using NGPlusPlus.BattleManagerNamespace;
using NGPlusPlus.EnemyNamespace;
using NGPlusPlus.Enums;
using NGPlusPlus.GameScreensNamespace;
using NGPlusPlus.GameSettingsNamespace;
using NGPlusPlus.PlayerNameSpace;
using NGPlusPlus.SceneManagerNamespace;
using NGPlusPlus.ScreenRendererNamespace;
using System.Xml.Linq;

namespace NGPlusPlus.Core {
    public static class Core {

        private static Player player;

        public static void InitializeGameSettings()
        {
            Console.SetWindowSize(GameSettings.WINDOW_WIDTH, GameSettings.WINDOW_HEIGHT);

            player = Player.GetInstance();
        }

        public static void StartGameLoop() 
        {
            var SceneManager = new SceneManager();

            SceneManager.PlayTitle();

            SceneManager.PlayIntro();

            var spider = new Enemy(EnemyType.Rat, "Black Widow", 1);
            var BattleManager = new BattleManager(spider, SceneManager, new SpiderScreen(spider), true);
            TextLogger.ClearWriteTextAndWait("Watch out! You're being attacked....");
            var wonBattle = BattleManager.CoreLoop();

            if (wonBattle)
            {
                SceneManager.PlayBattleWon();
            }
            else
            {
                SceneManager.PlayGameOver();
            }
                
        }

        public static bool RestartGame() 
        {
            var restart = "";

            do
            {
                TextLogger.ClearWriteText("Would you like to start a new game?");
                TextLogger.WriteText("y or n");
                restart = Console.ReadLine();
            } while (restart.ToLower() != "y" && restart.ToLower() != "n");

            return restart.ToLower() == "y";
        }
    }
}