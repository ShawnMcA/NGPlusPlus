using NGPlusPlus.Enums;
using NGPlusPlus.Interfaces;
using NGPlusPlus.PlayerNameSpace;
using System.Numerics;

namespace NGPlusPlus.SceneManagerNamespace
{
    internal static class CoreSceneManager
    {
        public static void PlayChapters(Player player, int sceneSkip = 0)
        {
            if (sceneSkip > 0)
                player.InitializePlayer();

            var scenes = new List<IStorySceneManager>() {
                new TitleSceneManager(),
                new Chapter1SceneManager(player),
                new Chapter2SceneManager(player),
                new Chapter3SceneManager(player),
                new Chapter4SceneManager(player),
                new Chapter5SceneManager(player),
                new Chapter6SceneManager(player),
                new Chapter7SceneManager(player),
                new Chapter8SceneManager(player),
                new Chapter9SceneManager(player),
                new Chapter10SceneManager(player),
                new Chapter11SceneManager(player),
                new Chapter12SceneManager(player),
                new Chapter13SceneManager(player),
            };

            for(var i = 0; i < scenes.Count; i++)
            {
                if (sceneSkip <= i)
                    scenes[i].PlaySet();

                if (!CheckContinuePlaying(player))
                    break;
            }

            RestartSceneManager.RestartGame();
        }

        public static void PlayMiscScene(MiscScenes scene)
        {
            switch (scene)
            {
                case MiscScenes.Blank: MiscSceneManager.PlayBlank(); break;
                default: break;
            }
        }

        private static bool CheckContinuePlaying(Player player)
        {
            return !player.Stats?.IsDead() ?? true;
        }
    }
}
