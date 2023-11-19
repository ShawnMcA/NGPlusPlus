using System;

namespace RPGGame.Data
{
    public static class SaveKey
    {
        #region "Player Keys"
        #region "Player Info"

        public const string Player_Name = "player_name";
        public const string Player_Level = "player_level";
        public const string Player_Class = "player_class";
        public const string Player_Experience = "player_experience";
        public const string Player_Experience_Needed = "player_experience_needed";

        #endregion "Player Info"

        #region "Player Stats"

        public const string Player_Max_Health = "player_max_health";
        public const string Player_Current_Health = "player_current_health";
        public const string Player_Max_Mana = "player_max_mana";
        public const string Player_Current_Mana = "player_current_mana";
        public const string Player_Attack = "player_attack";
        public const string Player_Defense = "player_defense";
        public const string Player_Magic_Attack = "player_magic_attack";
        public const string Player_Magic_Defense = "player_magic_defense";
        public const string Player_Speed = "player_speed";

        #endregion "Player Stats"

        #endregion "Player Keys"

    }
}

