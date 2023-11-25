using NGPlusPlus.Core;
using NGPlusPlus.GameScreensNamespace;
using NGPlusPlus.ScreenRendererNamespace;

namespace NGPlusPlus.SceneManagerNamespace
{
    internal static class RestartSceneManager
    {
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
