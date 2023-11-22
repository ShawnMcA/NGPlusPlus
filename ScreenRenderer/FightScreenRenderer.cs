using NGPlusPlus.EnemyNamespace;
using NGPlusPlus.GameScreensNamespace;
using NGPlusPlus.GameSettingsNamespace;
using NGPlusPlus.Interfaces;

namespace NGPlusPlus.ScreenRendererNamespace
{
    public class FightScreenRenderer
    {
        private static IGameScreen FightScreen;
        private static IGameScreen StatBox;
        private static IGameScreen AbilityMenu;
        private static IGameScreen EnemyScreen;

        public FightScreenRenderer(IGameScreen enemyScreen) {
            FightScreen = new FightScreen();
            StatBox = new StatBox();
            AbilityMenu = new AbilityMenu();
            EnemyScreen = enemyScreen;
        }

        public void RenderFightScreen()
        {
            RenderBackground();
            RenderStatBox();
            RenderActionBox();
            RenderEnemyAnimation();
        }

        private void RenderBackground()
        {
            ScreenRenderer.RenderScreen(FightScreen.Screen1());
        }

        private void RenderStatBox() 
        {
            ScreenRenderer.RenderSection(StatBox.Screen1(),
                GameSettings.COMBAT_STATS_WINDOW_START_LEFT,
                GameSettings.COMBAT_STATS_WINDOW_START_TOP,
                GameSettings.COMBAT_STATS_WINDOW_WIDTH,
                GameSettings.COMBAT_STATS_WINDOW_HEIGHT);
        }

        private void RenderActionBox()
        {
            ScreenRenderer.RenderSection(AbilityMenu.Screen1(),
                GameSettings.COMBAT_ACTION_WINDOW_START_LEFT,
                GameSettings.COMBAT_ACTION_WINDOW_START_TOP,
                GameSettings.COMBAT_ACTION_WIDOW_WIDTH,
                GameSettings.COMBAT_ACTION_WINDOW_HEIGHT);
        }

        private void RenderEnemyAnimation()
        {
            ScreenRenderer.RenderAnimation(EnemyScreen,
                GameSettings.COMBAT_ENEMY_WINDOW_START_LEFT,
                GameSettings.COMBAT_ENEMY_WINDOW_START_TOP,
                GameSettings.COMBAT_ENEMY_WIDOW_WIDTH,
                GameSettings.COMBAT_ENEMY_WINDOW_HEIGHT);
        }
    }
}
