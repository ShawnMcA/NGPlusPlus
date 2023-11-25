using NGPlusPlus.GameScreensNamespace;
using NGPlusPlus.ScreenRendererNamespace;

namespace NGPlusPlus.SceneManagerNamespace
{
    internal static class MiscSceneManager
    {
        public static void PlayBlank() 
        {
            var blank = new BlankScreen();

            ScreenRenderer.RenderAnimation(blank);
        }
    }
}
