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
    internal class Chapter4SceneManager : IStorySceneManager, IChapterSceneManager
    {
        private Player Player;
        public Chapter4SceneManager(Player player)
        {
            Player = player;
        }

        public void PlaySet()
        {
            PlayChapterScene();
            TheWiseMan();
        }

        public void PlayChapterScene()
        {
            ScreenRenderer.RenderAnimation(new Chapter4Screen());
            TextLogger.ClearWriteTextAndWait("");
        }

        private void TheWiseMan()
        {
            CoreSceneManager.PlayMiscScene(MiscScenes.Blank);
            TextLogger.ClearWriteTextAndWait($"???: Welcome, you must have many questions.");
            TextLogger.ClearWriteTextAndWait($"{CharacterNames.NPC_WISE_MAN}: My name is {CharacterNames.NPC_WISE_MAN}, The Wise.");
            TextLogger.ClearWriteTextAndWait($"{CharacterNames.NPC_WISE_MAN}: I’m sorry for putting you through all I have, but I needed to know you were ready.");
            TextLogger.ClearWriteTextAndWait($"{CharacterNames.NPC_WISE_MAN}: This world we are in is unstable and collapsing.");
            TextLogger.ClearWriteTextAndWait($"{CharacterNames.NPC_WISE_MAN}: It seems your presence here has caused a great imbalance and is tearing this world apart.");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: This... Is all so overwhelming...");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: Me? I’m what’s tearing the world apart?");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: I'm not even sure how I got to this place or who I am?");
            TextLogger.ClearWriteTextAndWait($"{CharacterNames.NPC_WISE_MAN}: While you are the cause of this destruction, you unfortunately are also the only one who can save this world.");
            TextLogger.ClearWriteTextAndWait($"{CharacterNames.NPC_WISE_MAN}: It seems as if your presence put our world on a timer.");
            TextLogger.ClearWriteTextAndWait($"{CharacterNames.NPC_WISE_MAN}: You must find and gather the four Sages to the location that brought you to this place. ");
            TextLogger.ClearWriteTextAndWait($"{CharacterNames.NPC_WISE_MAN}: Once there, you should know what to do.");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: That’s all very vague...");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: Four Sages? Who are the four sages?");
            TextLogger.ClearWriteTextAndWait($"{CharacterNames.NPC_WISE_MAN}: The four sages are as follows:");
            TextLogger.ClearWriteTextAndWait($"{CharacterNames.NPC_WISE_MAN}: The Protector, The Forgetful, The Creator, and The Impatient");
            TextLogger.ClearWriteTextAndWait($"{CharacterNames.NPC_WISE_MAN}: Unfortunately, you will have to find the Sages on your own.");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: Geeee, thanks...");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: You spring all of this heavy information on me all at once and leave me with practically nothing?");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: I’m not even sure where to start looking for these Sages.");
            TextLogger.ClearWriteTextAndWait($"{CharacterNames.NPC_WISE_MAN}: I believe in you {Player.Name}.");
            TextLogger.ClearWriteTextAndWait($"{CharacterNames.NPC_WISE_MAN}: Good luck...");
            TextLogger.ClearWriteTextAndWait($"(Thanks...)");
            TextLogger.ClearWriteTextAndWait($"(I guess...");
        }
    }
}
