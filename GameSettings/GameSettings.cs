using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame.GameSettingsNamespace
{
    public static class GameSettings
    {

        // Whole Game Window  
        public const int WINDOW_HEIGHT = 42;
        public const int WINDOW_WIDTH = 120;

        // Whole game screen with border
        public const int DISPLAY_HEIGHT = WINDOW_HEIGHT - 12;
        public const int DISPLAY_WIDTH = WINDOW_WIDTH;

        // Inside of game screen
        public const int MAX_SCREEN_ROWS = DISPLAY_HEIGHT - 4;
        public const int MAX_SCREEN_ROW_CHARS = DISPLAY_WIDTH - 4;

        // Inside of fight screen stats section
        public const int COMBAT_STATS_WINDOW_WIDTH = 30;
        public const int COMBAT_STATS_WINDOW_HEIGHT = 7;
        public const int COMBAT_STATS_WINDOW_START_TOP = 20;
        public const int COMBAT_STATS_WINDOW_START_LEFT = 9;
        // Combat Stats Window Coordinates    (x, y) ( TL(09, 20), TR(39, 20),  BL(09, 26), BR(39, 26)  )

        // Inside of fight screen action section
        public const int COMBAT_ACTION_WIDOW_WIDTH = 70;
        public const int COMBAT_ACTION_WINDOW_HEIGHT = 7;
        public const int COMBAT_ACTION_WINDOW_START_TOP = 20;
        public const int COMBAT_ACTION_WINDOW_START_LEFT = 41;
        // Combat Action Window Coordinates            ( TL(41, 20), TR(111, 20), BL(41, 26), BR(111, 26) )

        // Inside of fight screen enemy section
        public const int COMBAT_ENEMY_WIDOW_WIDTH = 40;
        public const int COMBAT_ENEMY_WINDOW_HEIGHT = 14;
        public const int COMBAT_ENEMY_WINDOW_START_TOP = 3;
        public const int COMBAT_ENEMY_WINDOW_START_LEFT = 40;
        // Enemy Window Coordinates                   ( TL(45, 3),  TR(75, 3),   BL(45, 17), BR(75, 17)  )
    }
}
