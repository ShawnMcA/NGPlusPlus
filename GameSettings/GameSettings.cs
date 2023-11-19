using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame.GameSettingsNamespace
{
    public static class GameSettings
    {
        public const int WINDOW_HEIGHT = 42;
        public const int WINDOW_WIDTH = 120;

        public const int DISPLAY_HEIGHT = WINDOW_HEIGHT - 12;
        public const int DISPLAY_WIDTH = WINDOW_WIDTH;

        public const int MAX_SCREEN_ROWS = DISPLAY_HEIGHT - 4;
        public const int MAX_SCREEN_ROW_CHARS = DISPLAY_WIDTH - 4;

        public const int COMBAT_STATS_WINDOW_WIDTH = 30;
        public const int COMBAT_STATS_WINDOW_HEIGHT = 30;
    }
}
