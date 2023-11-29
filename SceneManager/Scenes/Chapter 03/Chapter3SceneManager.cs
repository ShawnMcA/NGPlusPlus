using NGPlusPlus.Core;
using NGPlusPlus.Enums;
using NGPlusPlus.PlayerNameSpace;
using NGPlusPlus.ScreenRendererNamespace;
using NGPlusPlus.Data;
using NGPlusPlus.GameScreensNamespace;
using NGPlusPlus.SceneManager.Core;
using NGPlusPlus.Interfaces;

namespace NGPlusPlus.SceneManagerNamespace
{
    internal class Chapter3SceneManager: IStorySceneManager, IChapterSceneManager
    {
        private Player Player;
        public Chapter3SceneManager(Player player)
        {
            Player = player;
        }

        public void PlaySet()
        {
            PlayChapterScene();
            ForkInTheRoad();
            ScaryWoods();
            DeeperWoods();
        }

        public void PlayChapterScene() 
        {
            ScreenRenderer.RenderAnimation(new Chapter3Screen());
            TextLogger.ClearWriteTextAndWait("");
        }

        private void ForkInTheRoad()
        {
            CoreSceneManager.PlayMiscScene(MiscScenes.Blank);
            TextLogger.ClearWriteText($"(After what feels like hours of walking, you come up to a fork in the road and a sign)");
            TextLogger.WriteText($" - Left -> Straight shot to town. Definitely no danger.");
            TextLogger.WriteTextAndWait($" - Right -> Scary Woods. Probably lots of danger.");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: Hmm...");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: I’ve seen enough movies and played enough games to know this is probably a trap.");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: Or is it a trap?");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: Maybe the trap is that they want you to think this is a trap...");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: I’m just going to let a coin flip decide which way to go.");
            TextLogger.ClearWriteTextAndWait($"(You search for longer than you should looking for a coin)");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: Hmm... I must have dropped my coins back wh...");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: ...who am I kidding... I never carry coins. ");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: I’ll just flip this leaf...");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: Top part of the leaf: I go left. Bottom part of the leaf: I go right.");
            TextLogger.ClearWriteTextAndWait($"(You flip the leaf, but it blows away)");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: I’ll just go right...");
            TextLogger.ClearWriteTextAndWait($"(You continue down the path feeling defeated.)");
        }

        private void ScaryWoods()
        {
            CoreSceneManager.PlayMiscScene(MiscScenes.Blank);
            TextLogger.ClearWriteTextAndWait($"(As you walk through the woods you start to think about what Phillip said.)");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: Why did Phillip welcome me back?");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: I’m not sure why I would have been here or even how I got here this time.");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: Truthfully, I’m not even sure where 'here' even is.");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: I can’t avoid the feeling that I know {CharacterNames.NPC_GIRL} though.");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: She definitely reminds me of someone.");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: Whoever her dad is, he must have some sort of answers for me.");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: I should make finding him my top...");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: UAGHHHHH, GROSSS");
            TextLogger.ClearWriteTextAndWait($"(You scramble around trying to get the spiderweb you just walked through off your face.)");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: Just my luck to walk through spiderwebs of all things...");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: At least it wasn’t a...");

            BattleSceneManager.StartBattle(EnemyType.Spider, $"Itsy Bitsy Spider", 1, true);
            CoreSceneManager.PlayMiscScene(MiscScenes.Blank);

            TextLogger.ClearWriteTextAndWait($"{Player.Name}: I should have predicted that...");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: At least that was just a baby.");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: After those last battles, that was a piece of cake.");

            BattleSceneManager.StartBattle(EnemyType.Spider, $"Beefy Spider", 1, true);
            CoreSceneManager.PlayMiscScene(MiscScenes.Blank);

            TextLogger.ClearWriteTextAndWait($"{Player.Name}: Okay... Come on...");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: At least it wasn't a... comfortable bed and hot meal?");
            TextLogger.ClearWriteTextAndWait($"(You look around, expecting magic to happen...)");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: Was worth a shot, I guess.");
            TextLogger.ClearWriteTextAndWait($"(You toss the dead spiders in the air and catch them like crunchy pieces of popcorn.)");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: Time to keep moving.");
        }

        private void DeeperWoods()
        {
            CoreSceneManager.PlayMiscScene(MiscScenes.Blank);
            TextLogger.ClearWriteTextAndWait($"(As you walk deeper into the woods you start losing a sense of time.)");
            TextLogger.ClearWriteTextAndWait($"(Is it still day? Is it night? How long have you been walking.)");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: I really need to find a place to crash.");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: After that spiderweb catastrophe, I don’t really trust this place.");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: ");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: What... What is that...?");
            TextLogger.ClearWriteTextAndWait($"(You’ve come to an open clearing in the forest with what looks like a giant rock in the middle.)");
            TextLogger.ClearWriteTextAndWait($"???: I’ve been waiting for you.");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: Who? Me?");
            TextLogger.ClearWriteTextAndWait($"???: Yes, {Player.Name}, I’ve been monitoring you since you’ve first arrived here.");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: Ohh boy...");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: So, you saw that whole spiderweb incident?");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: That’s a little embarrassing...");
            TextLogger.ClearWriteTextAndWait($"???: I did. In fact, those were actually tests of your abilities.");
            TextLogger.ClearWriteTextAndWait($"???: I needed to know if you were strong enough.");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: Maybe you could have tested me in a different way.");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: Like...");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: A nice 500-piece puzzle… Challenging, but not TOO challenging, you know?");
            TextLogger.ClearWriteTextAndWait($"???: ...");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: ...");
            TextLogger.ClearWriteTextAndWait($"???: You may not know this yet, but your wellness is my top priority.");
            TextLogger.ClearWriteTextAndWait($"???: That’s why I must test you.");
            TextLogger.ClearWriteTextAndWait($"???: To ensure you are strong enough to handle the task.");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: What task?");
            TextLogger.ClearWriteTextAndWait($"???: In due time...");
            TextLogger.ClearWriteTextAndWait($"???: Now, I have one last test for you before we meet...");
            TextLogger.ClearWriteTextAndWait($"???: My prized possession.");
            TextLogger.ClearWriteTextAndWait($"???: Good luck...");

            BattleSceneManager.StartBattle(EnemyType.Spider, $"{CharacterNames.BOSS_Boss1}", 2, true);
            CoreSceneManager.PlayMiscScene(MiscScenes.Blank);


            TextLogger.ClearWriteTextAndWait($"???: Congrats, you've passed...");
            TextLogger.ClearWriteTextAndWait($"???: Please, follow the path below and meet me in my study.");
            TextLogger.ClearWriteTextAndWait($"(The large rock in the center of the clearing moves out of the way to reveal a staircase)");
            TextLogger.ClearWriteTextAndWait($"(You dive down the stairs into the unknown)");
        }
    }
}
