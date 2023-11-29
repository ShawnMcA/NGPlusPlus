using NGPlusPlus.Core;
using NGPlusPlus.Enums;
using NGPlusPlus.PlayerNameSpace;
using NGPlusPlus.ScreenRendererNamespace;
using NGPlusPlus.GameScreens.Scenes;
using NGPlusPlus.Data;
using NGPlusPlus.GameScreensNamespace;
using NGPlusPlus.SceneManager.Core;
using NGPlusPlus.Interfaces;

namespace NGPlusPlus.SceneManagerNamespace
{
    internal class Chapter10SceneManager: IStorySceneManager, IChapterSceneManager
    {
        private Player Player;
        public Chapter10SceneManager(Player player)
        {
            Player = player;
        }
        public void PlaySet()
        {
            PlayChapterScene();
        }

        public void PlayChapterScene() 
        {
            ScreenRenderer.RenderAnimation(new Chapter10Screen());
            TextLogger.ClearWriteTextAndWait("");
        }

    }
}
