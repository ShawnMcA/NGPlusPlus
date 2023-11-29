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
    internal class Chapter2SceneManager: IStorySceneManager, IChapterSceneManager
    {
        private Player Player;
        public Chapter2SceneManager(Player player)
        {
            Player = player;
        }

        public void PlaySet()
        {
            PlayChapterScene();
            OnTheRoad();
            Starla();
            StarlaPostBattle();
        }

        public void PlayChapterScene() 
        {
            ScreenRenderer.RenderAnimation(new Chapter2Screen());
            TextLogger.ClearWriteTextAndWait("");
        }

        private void OnTheRoad()
        {
            CoreSceneManager.PlayMiscScene(MiscScenes.Blank);
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: Man, I really screwed that up back there...");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: I almost had a place to stay.");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: A soft bed... cozy house...");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: Confusingly comfy, but angry pillow...");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: Something in me still feels like I’ve been there before.");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: That {CharacterNames.NPC_BOY} was a really odd dude too.");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: I feel really bad about {CharacterNames.NPC_BOY_PET}.");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: I’d better find a place to stay soon though...");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: It’s been such...");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: a... long.....");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: (Immediately crashes and passes out on the road)");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: ");
        }

        private void Starla()
        {
            TextLogger.ClearWriteTextAndWait($"???: EXCUSE YOU...");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: Huh?");
            TextLogger.ClearWriteTextAndWait($"???: You can’t just sleep wherever you want you know...");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: ?");
            TextLogger.ClearWriteTextAndWait($"???: Never mind... I have more important things to do right now anyway...");
            TextLogger.ClearWriteTextAndWait($"???: I'm taking my pet snake, to the lake down the road for a jump rope competition.");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: Let me guess... Is its name Jake? ");
            TextLogger.ClearWriteTextAndWait($"???: No...?");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: Blake?");
            TextLogger.ClearWriteTextAndWait($"???: No????");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: Small Chocolate Snake, hold the whipped cream?");
            TextLogger.ClearWriteTextAndWait($"???: I don't have time for this...");
            TextLogger.ClearWriteTextAndWait($"???: My dad was supposed to give me some money for a jump rope, but I can't find him anywhere...");
            TextLogger.ClearWriteTextAndWait($"???: So...");
            TextLogger.ClearWriteTextAndWait($"???: {CharacterNames.NPC_GIRL_PET} will have to do, I guess...");
            TextLogger.ClearWriteTextAndWait($"???: You know, you should enter with your pet too.");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: What pet?");
            TextLogger.ClearWriteTextAndWait($"(The little girl points to your shoulder)");

            BattleSceneManager.StartBattle(EnemyType.Snake, $"Shoulder Snake", 1, true);
        }

        private void StarlaPostBattle()
        {
            TextLogger.ClearWriteTextAndWait($"???: Well, that was weird.");
            TextLogger.ClearWriteTextAndWait($"{CharacterNames.NPC_GIRL}: My name is {CharacterNames.NPC_GIRL} by the way.");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: {Player.Name}.");
            TextLogger.ClearWriteTextAndWait($"{CharacterNames.NPC_GIRL}: Nice to meet you.");
            TextLogger.ClearWriteTextAndWait($"{CharacterNames.NPC_GIRL}: I have to get going, but if you see my dad tell him I'm looking for him.");
            TextLogger.ClearWriteTextAndWait($"({CharacterNames.NPC_GIRL} runs off.)");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: That girl seemed oddly familiar...");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: Definitely a strange one nonetheless.");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: I should probably find someone who could help me figure out where I am and how I got here.");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: Maybe {CharacterNames.NPC_GIRL}'s dad would know more. Whoever that is.");
            TextLogger.ClearWriteTextAndWait($"(You continue on down the road)");
        }

    }
}
