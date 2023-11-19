using RPGGame.Core;
using RPGGame.EnemyNamespace;
using RPGGame.Enums;
using RPGGame.GameScreensNamespace;
using RPGGame.Interfaces;
using RPGGame.PlayerNameSpace;
using RPGGame.ScreenRendererNamespace;

namespace RPGGame.SceneManagerNamespace
{
    internal class SceneManager
    {
        private IGameScreen TitleScreen;
        private IGameScreen Intro;
        private IGameScreen GameOver;
        private IGameScreen FightScreen;
        private IGameScreen BattleWon;

        private Player player;

        public SceneManager()
        {
            TitleScreen = new TitleScreen();
            Intro = new Intro();
            GameOver = new GameOver();
            BattleWon = new BattleWon();
            player = Player.GetInstance();
        }

        public void PlayTitle() 
        {
            ScreenRenderer.RenderAnimation(TitleScreen);

            TextLogger.ClearWriteTextAndWait("Press any key to start your adventure...");
            TextLogger.ClearWindow();
        }

        public void PlayIntro() 
        {
            ScreenRenderer.RenderAnimation(Intro);

            TextLogger.ClearWriteTextAndWait("Welcome to nowhere... Hope you aren't lost...");

            player.InitializePlayer(GetUserName());

            TextLogger.ClearWriteTextAndWait($"Hello {player.Name}!!");

        }

        public void PlayFightScreen(Enemy enemy)
        {
            FightScreen = new FightScreen(enemy);
            ScreenRenderer.RenderAnimation(FightScreen);
        }
        public void PlayBattleWon()
        {
            ScreenRenderer.RenderAnimation(BattleWon);

            TextLogger.ClearWriteTextAndWait("Congrats!! You made it out alive...");

            player.ResetPlayer();
        }

        public void PlayGameOver()
        {
            ScreenRenderer.RenderAnimation(GameOver);

            TextLogger.ClearWriteTextAndWait("Ohh no... It seems you're no longer with us. It was fun while it lasted...");

            player.ResetPlayer();
        }

        private static string GetUserName()
        {
            TextLogger.ClearWriteText("What is your name?");
            var name = Console.ReadLine();

            while (string.IsNullOrEmpty(name))
            {
                TextLogger.ClearWriteText("Sorry, you must enter a name: ");
                name = Console.ReadLine();
            }

            return name;
        }
    }
}
