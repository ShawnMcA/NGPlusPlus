using NGPlusPlus.Core;
using NGPlusPlus.Enums;
using NGPlusPlus.PlayerNameSpace;
using NGPlusPlus.ScreenRendererNamespace;
using NGPlusPlus.GameScreens.Scenes;
using NGPlusPlus.Data;

namespace NGPlusPlus.SceneManagerNamespace
{
    internal static class IntroSceneManager
    {
        public static void PlayIntro() 
        {
            var intro = new IntroScreen();

            ScreenRenderer.RenderAnimation(intro);

            TextLogger.ClearWriteTextAndWait("???: Welcome to nowhere... Hope you aren't lost...");
            TextLogger.ClearWriteTextAndWait("???: You look familiar though.");

            var name = GetPlayerName();

            TextLogger.ClearWriteTextAndWait($"???: Well, nice to meet you {name}. Or welcome back?");
            TextLogger.ClearWriteTextAndWait($"???: I’m not sure at this point...");
            var playerClass = GetPlayerClass();

            var player = Player.GetInstance();
            player.InitializePlayer(name, playerClass);


            TextLogger.ClearWriteTextAndWait("???: Ahh, I was close I guess...");
            TextLogger.ClearWriteTextAndWait("???: Either way, it’s good to have you here.");
            TextLogger.ClearWriteTextAndWait("???: It’s been pretty lonely here lately...");
            TextLogger.ClearWriteTextAndWait("???: I almost forgot. You probably want to know who I am.");
            TextLogger.ClearWriteTextAndWait($"{CharacterNames.NPC1}: My name is {CharacterNames.NPC1}. I think at least...");
            TextLogger.ClearWriteTextAndWait($"{CharacterNames.NPC1}: Nevertheless, you're probably tired.");
            TextLogger.ClearWriteTextAndWait($"{CharacterNames.NPC1}: I have a spare room upstairs. You'd better stay here for the night.");
            TextLogger.ClearWriteTextAndWait($"{CharacterNames.NPC1}: Just watch out for {CharacterNames.NPC1sPet}. He can be a little cranky...");
            TextLogger.ClearWriteTextAndWait($"{CharacterNames.NPC1}: Anyway, hope you sleep well...");
            TextLogger.ClearWriteTextAndWait("(You head upstairs for your room.)");
        }

        private static PlayerClass GetPlayerClass()
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

        private static string GetPlayerName()
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
