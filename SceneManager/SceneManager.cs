using NGPlusPlus.Core;
using NGPlusPlus.EnemyNamespace;
using NGPlusPlus.Enums;
using NGPlusPlus.GameScreensNamespace;
using NGPlusPlus.Interfaces;
using NGPlusPlus.PlayerNameSpace;
using NGPlusPlus.ScreenRendererNamespace;

namespace NGPlusPlus.SceneManagerNamespace
{
    internal class SceneManager
    {
        private readonly Player Player;

        public SceneManager()
        {
            Player = Player.GetInstance();
        }

        public void PlayTitle() 
        {
            var titleScreen = new TitleScreen();

            ScreenRenderer.RenderAnimation(titleScreen);

            TextLogger.ClearWriteTextAndWait("Press any key to start your adventure...");
            TextLogger.ClearWindow();
        }

        public void PlayIntro() 
        {
            var intro = new Intro();

            ScreenRenderer.RenderAnimation(intro);

            TextLogger.ClearWriteTextAndWait("Welcome to nowhere... Hope you aren't lost...");

            var name = GetPlayerName();

            var playerClass = GetPlayerClass();

            Player.InitializePlayer(name, playerClass);

        }

        public void PlayFightScreen(IGameScreen enemyScreen)
        {
            var fightScreenRenderer = new FightScreenRenderer(enemyScreen);
            fightScreenRenderer.RenderFightScreen();
        }

        public void PlayBattleWon()
        {
            var battleWon = new BattleWon();
            ScreenRenderer.RenderAnimation(battleWon);

            TextLogger.ClearWriteTextAndWait("Congrats!! You made it out alive...");

            Player.ResetPlayer();
        }

        public void PlayGameOver()
        {
            var gameOver = new GameOver();

            ScreenRenderer.RenderAnimation(gameOver);

            TextLogger.ClearWriteTextAndWait("Ohh no... It seems you're no longer with us. It was fun while it lasted...");

            Player.ResetPlayer();
        }

        private static PlayerClass GetPlayerClass()
        {
            int classType;

            var enumNames = Enum.GetNames(typeof(PlayerClass));

            do
            {
                TextLogger.ClearWriteText("What playstyle would you prefer for this adventure?");

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
            TextLogger.ClearWriteText("What is your name?");
            var name = Console.ReadLine();

            while (string.IsNullOrEmpty(name))
            {
                TextLogger.ClearWriteText("Sorry, you must enter a name: ");
                name = Console.ReadLine();
            }

            TextLogger.ClearWriteTextAndWait($"Hello {name}!!");

            return name;
        }
    }
}
