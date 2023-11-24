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

        public static void StartGameLoop() 
        {
            SceneManager.PlayTitle();

            SceneManager.PlayIntro();
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