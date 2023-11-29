using NGPlusPlus.Core;
using NGPlusPlus.GameScreens.Core;
using NGPlusPlus.Interfaces;
using NGPlusPlus.ScreenRendererNamespace;

namespace NGPlusPlus.SceneManagerNamespace
{
    internal class TitleSceneManager: IStorySceneManager
    {
        public void PlaySet() 
        {
            PlayTitle();
        }

        public void PlayTitle()
        {
            var titleScreen = new TitleScreen();

            ScreenRenderer.RenderAnimation(titleScreen);

            TextLogger.ClearWriteTextAndWait("Press any key to start your adventure...");
            TextLogger.ClearWindow();
        }
    }
}
