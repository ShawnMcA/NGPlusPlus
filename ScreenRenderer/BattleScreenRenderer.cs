﻿using NGPlusPlus.GameScreens.Core;
using NGPlusPlus.GameScreensNamespace;
using NGPlusPlus.GameSettingsNamespace;
using NGPlusPlus.Interfaces;

namespace NGPlusPlus.ScreenRendererNamespace
{
    public static class BattleScreenRenderer
    {
        public static void RenderFightScreen(IGameScreen enemyScreen)
        {
            RenderBackground();
            RenderStatBox();
            RenderActionBox();
            RenderEnemyAnimation(enemyScreen);
        }

        public static void RenderBackground()
        {

            ScreenRenderer.RenderScreen(new FightScreen().Screen1());
        }

        public static void RenderStatBox() 
        {
            ScreenRenderer.RenderSection(new StatBoxScreen().Screen1(),
                GameSettings.COMBAT_STATS_WINDOW_START_LEFT,
                GameSettings.COMBAT_STATS_WINDOW_START_TOP,
                GameSettings.COMBAT_STATS_WINDOW_WIDTH,
                GameSettings.COMBAT_STATS_WINDOW_HEIGHT);
        }

        public static void RenderActionBox()
        {
            ScreenRenderer.RenderSection(new AbilityMenuScreen().Screen1(),
                GameSettings.COMBAT_ACTION_WINDOW_START_LEFT,
                GameSettings.COMBAT_ACTION_WINDOW_START_TOP,
                GameSettings.COMBAT_ACTION_WIDOW_WIDTH,
                GameSettings.COMBAT_ACTION_WINDOW_HEIGHT);
        }

        public static void RenderEnemyAnimation(IGameScreen enemyScreen)
        {
            ScreenRenderer.RenderAnimation(enemyScreen,
                GameSettings.COMBAT_ENEMY_WINDOW_START_LEFT,
                GameSettings.COMBAT_ENEMY_WINDOW_START_TOP,
                GameSettings.COMBAT_ENEMY_WIDOW_WIDTH,
                GameSettings.COMBAT_ENEMY_WINDOW_HEIGHT);
        }
    }
}
