using NGPlusPlus.Enums;

namespace NGPlusPlus.SceneManagerNamespace
{
    internal static class SceneManager
    {
        private static Scenes CURRENT_SCENE = Scenes.Title;

        public static void PlayNextScene()
        {
            PlayScene(CURRENT_SCENE);
            CURRENT_SCENE++;
        }

        public static void SkipToScene(Scenes scene) 
        {
            CURRENT_SCENE = scene;

            PlayNextScene();
        }

        public static void ResetSceneManager()
        {
            CURRENT_SCENE = Scenes.Title;
        }

        public static bool IsFinalScene()
        {
            var finalScene = Enum.GetValues(typeof(Scenes)).Cast<int>().Max();

            return (int)CURRENT_SCENE == finalScene + 1;
        }

        private static void PlayScene(Scenes scene)
        {
            switch (scene)
            {
                case Scenes.Title: TitleSceneManager.PlayTitle(); break;
                case Scenes.Intro: IntroSceneManager.PlayIntro(); break;
                case Scenes.BedroomStart: BedroomSceneManager.PlayBedroomStart(); break;
                case Scenes.BedroomAfter: BedroomSceneManager.PlayBedroomAfter(); break;
                default: break;
            }
        }

        public static void PlayMiscScene(MiscScenes scene)
        {
            switch (scene)
            {
                default: break;
            }
        }
    }
}
