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
    internal class Chapter1SceneManager: IStorySceneManager, IChapterSceneManager
    {
        private Player Player;
        public Chapter1SceneManager(Player player)
        {
            Player = player;
        }

        public void PlaySet()
        {
            PlayIntro();
            PlayChapterScene();
            PlayBedroomStart();
            PlayBedroomAfter();
        }

        public void PlayChapterScene() 
        {
            ScreenRenderer.RenderAnimation(new Chapter1Screen());
            TextLogger.ClearWriteTextAndWait("");
        }

        private void PlayIntro()
        {
            var intro = new IntroScreen();

            ScreenRenderer.RenderAnimation(intro);

            TextLogger.ClearWriteTextAndWait("???: Welcome to nowhere... Hope you aren't lost...");
            TextLogger.ClearWriteTextAndWait("???: You look familiar though.");

            var name = GetPlayerName();

            TextLogger.ClearWriteTextAndWait($"???: Well, nice to meet you {name}. Or welcome back?");
            TextLogger.ClearWriteTextAndWait($"???: I’m not sure at this point...");
            var playerClass = GetPlayerClass();

            Player.InitializePlayer(name, playerClass);


            TextLogger.ClearWriteTextAndWait("???: Ahh, I was close I guess...");
            TextLogger.ClearWriteTextAndWait("???: Either way, it’s good to have you here.");
            TextLogger.ClearWriteTextAndWait("???: It’s been pretty lonely here lately...");
            TextLogger.ClearWriteTextAndWait("???: I almost forgot. You probably want to know who I am.");

            var npc1Screen = new Npc1Screen();
            ScreenRenderer.RenderAnimation(npc1Screen);
            TextLogger.ClearWriteTextAndWait($"{CharacterNames.NPC_BOY}: My name is {CharacterNames.NPC_BOY}. I think at least...");
            TextLogger.ClearWriteTextAndWait($"{CharacterNames.NPC_BOY}: Nevertheless, you're probably tired.");
            TextLogger.ClearWriteTextAndWait($"{CharacterNames.NPC_BOY}: I have a spare room upstairs. You'd better stay here for the night.");
            TextLogger.ClearWriteTextAndWait($"{CharacterNames.NPC_BOY}: Just watch out for {CharacterNames.NPC_BOY_PET}. He can be a little cranky...");
            TextLogger.ClearWriteTextAndWait($"{CharacterNames.NPC_BOY}: Anyway, hope you sleep well...");

            CoreSceneManager.PlayMiscScene(MiscScenes.Blank);
            TextLogger.ClearWriteTextAndWait("(You head upstairs for your room.)");
        }

        private void PlayBedroomStart()
        {
            var bedroomScreen = new BedroomScreen();
            ScreenRenderer.RenderAnimation(bedroomScreen);

            TextLogger.ClearWriteTextAndWait($"{Player.Name}: Man, this place is pretty... (Worn down? Dirty? Small?)");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: Cozy... Yeah, let's go with cozy...");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: Better than nothing, I guess...");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: I wonder where the hell I am? Or why that guy was so weird?");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: Have I been here before?");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: Also, who is {CharacterNames.NPC_BOY_PET}? Everything about this situation is confusing.");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: I'd better get some rest...");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: I'll just go ahead and move this oddly comfortable looking pillow out of the way...");

            BattleSceneManager.StartBattle(EnemyType.Rat, $"{CharacterNames.NPC_BOY_PET}: Not A Pillow", 1, true);
        }

        private void PlayBedroomAfter()
        {

            var player = Player.GetInstance();
            CoreSceneManager.PlayMiscScene(MiscScenes.Blank);
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: Well...");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: That probably wasn't good...");
            var angryNpcScreen = new AngryNpc1Screen();
            ScreenRenderer.RenderAnimation(angryNpcScreen);
            TextLogger.ClearWriteTextAndWait($"{CharacterNames.NPC_BOY}: WHAT THE HELL DID YOU DO TO {CharacterNames.NPC_BOY_PET.ToUpper()}?!?");
            TextLogger.ClearWriteTextAndWait($"{CharacterNames.NPC_BOY}: I CANNOT BELIEVE YOU RIGHT NOW...");
            TextLogger.ClearWriteTextAndWait($"{CharacterNames.NPC_BOY}: GET OUT!!!");
            TextLogger.ClearWriteTextAndWait($"{CharacterNames.NPC_BOY}: (Worst toilet paper salesperson ever... Jeez)");
            CoreSceneManager.PlayMiscScene(MiscScenes.Blank);
            TextLogger.ClearWriteTextAndWait($"(You hand over what's left of {CharacterNames.NPC_BOY_PET} and head out.)");
        }

        private PlayerClass GetPlayerClass()
        {
            int classType;

            var enumNames = Enum.GetNames(typeof(PlayerClass));

            do
            {
                TextLogger.ClearWriteTextAndWait("???: You must be some sort of... No, don't tell me...");
                TextLogger.ClearWriteText("???: Toilet paper salesperson?");

                for (var i = 0; i < enumNames.Length; i++)
                {
                    TextLogger.WriteText($"{i + 1}) {enumNames[i]}");
                }

                int.TryParse(Console.ReadLine(), out classType);
            } while (classType <= 0 || classType > enumNames.Length);

            return (PlayerClass)classType - 1;
        }

        private string GetPlayerName()
        {
            TextLogger.ClearWriteText("???: What was your name again: ");
            var name = Console.ReadLine();

            while (string.IsNullOrEmpty(name))
            {
                TextLogger.ClearWriteText("???: Sorry, you must have a name: ");
                name = Console.ReadLine();
            }

            return name;
        }
    }
}
