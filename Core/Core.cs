using NGPlusPlus.GameSettingsNamespace;
using NGPlusPlus.PlayerNameSpace;
using NGPlusPlus.SceneManagerNamespace;

namespace NGPlusPlus.Core {
    public static class Core {

        private static Player Player;

        private static int SceneSkip = 3;

        public static void InitializeGameSettings()
        {
            Console.SetWindowSize(GameSettings.WINDOW_WIDTH, GameSettings.WINDOW_HEIGHT);
            Console.SetBufferSize(GameSettings.WINDOW_WIDTH, GameSettings.WINDOW_HEIGHT);

            Player = Player.GetInstance();
        }

        public static void StartGameLoop()
        {
            CoreSceneManager.PlayChapters(Player, SceneSkip);
        }

        
    }
}