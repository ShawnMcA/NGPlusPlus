using NGPlusPlus.Core;
using NGPlusPlus.Enums;
using NGPlusPlus.PlayerNameSpace;
using NGPlusPlus.ScreenRendererNamespace;
using NGPlusPlus.GameScreens.Scenes;
using NGPlusPlus.Data;
using NGPlusPlus.GameScreensNamespace;

namespace NGPlusPlus.SceneManagerNamespace
{
    internal static class BedroomSceneManager
    {
        public static void PlayBedroomStart()
        {
            var bedroomScreen = new BedroomScreen();
            ScreenRenderer.RenderAnimation(bedroomScreen);

            var player = Player.GetInstance();

            TextLogger.ClearWriteTextAndWait($"{player.Name}: Man, this place is pretty... (Worn down? Dirty? Small?)");
            TextLogger.ClearWriteTextAndWait($"{player.Name}: Cozy... Yeah, let's go with cozy...");
            TextLogger.ClearWriteTextAndWait($"{player.Name}: Better than nothing, I guess...");
            TextLogger.ClearWriteTextAndWait($"{player.Name}: I wonder where the hell I am? Or why that guy was so weird?");
            TextLogger.ClearWriteTextAndWait($"{player.Name}: Have I been here before?");
            TextLogger.ClearWriteTextAndWait($"{player.Name}: Also, who is {CharacterNames.NPC1sPet}? Everything about this situation is confusing.");
            TextLogger.ClearWriteTextAndWait($"{player.Name}: I'd better get some rest...");
            TextLogger.ClearWriteTextAndWait($"{player.Name}: I'll just go ahead and move this oddly comfortable looking pillow out of the way...");

            BattleSceneManager.StartBattle(EnemyType.Rat, "Not A Pillow", 1, true);
        }

        public static void PlayBedroomAfter()
        {

            var player = Player.GetInstance();
            SceneManager.PlayMiscScene(MiscScenes.Blank);
            TextLogger.ClearWriteTextAndWait($"{player.Name}: Well...");
            TextLogger.ClearWriteTextAndWait($"{player.Name}: That probably wasn't good...");
            var angryNpcScreen = new AngryNpc1Screen();
            ScreenRenderer.RenderAnimation(angryNpcScreen);
            TextLogger.ClearWriteTextAndWait($"{CharacterNames.NPC1}: WHAT THE HELL DID YOU DO TO {CharacterNames.NPC1sPet.ToUpper()}?!?");
            TextLogger.ClearWriteTextAndWait($"{CharacterNames.NPC1}: I CANNOT BELIEVE YOU RIGHT NOW...");
            TextLogger.ClearWriteTextAndWait($"{CharacterNames.NPC1}: GET OUT!!!");
            TextLogger.ClearWriteTextAndWait($"{CharacterNames.NPC1}: (Worst toilet paper salesperson ever... Jeez)");
            SceneManager.PlayMiscScene(MiscScenes.Blank);
            TextLogger.ClearWriteTextAndWait($"(You hand over what's left of {CharacterNames.NPC1sPet} and head out.)");
        }
    }
}
