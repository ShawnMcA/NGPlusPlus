using NGPlusPlus.Enums;
using NGPlusPlus.GameSettingsNamespace;
using NGPlusPlus.PlayerNameSpace;
using NGPlusPlus.SceneManagerNamespace;

namespace NGPlusPlus.Core {
    public static class Core {

        private static Player Player;

        public static void InitializeGameSettings()
        {
            Console.SetWindowSize(GameSettings.WINDOW_WIDTH, GameSettings.WINDOW_HEIGHT);
            Console.SetBufferSize(GameSettings.WINDOW_WIDTH, GameSettings.WINDOW_HEIGHT);

            Player = Player.GetInstance();
        }

        public static bool StartGameLoop()
        {
            SceneManager.ResetSceneManager();

            do
            {
                SceneManager.PlayNextScene();

            } while (CheckContinuePlaying());

            return RestartSceneManager.RestartGame();
        }

        private static bool CheckContinuePlaying()
        {
            return !SceneManager.IsFinalScene() && (!Player.Stats?.IsDead() ?? true);
        }
    }
}