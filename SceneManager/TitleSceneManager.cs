using NGPlusPlus.Core;
using NGPlusPlus.GameScreensNamespace;
using NGPlusPlus.ScreenRendererNamespace;

namespace NGPlusPlus.SceneManagerNamespace
{
    internal static class TitleSceneManager
    {
        public static void PlayTitle()
        {
            var titleScreen = new TitleScreen();

            ScreenRenderer.RenderAnimation(titleScreen);

            TextLogger.ClearWriteTextAndWait("Press any key to start your adventure...");
            TextLogger.ClearWindow();
        }
    }
}
