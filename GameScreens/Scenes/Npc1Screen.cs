using NGPlusPlus.Interfaces;

namespace NGPlusPlus.GameScreens.Scenes
{
    internal class Npc1Screen : IGameScreen
    {
        public int AnimationSpeed => 300;
        public List<List<string>> AnimationPackage()
        {
            var package = new List<List<string>>
            {
                Screen1(),
                Screen1(),
                Screen2(),
                Screen2(),
                Screen1(),
                Screen1(),
            };

            return package;
        }

        public List<string> Screen1()
        {
            var screen = new List<string>();

            screen.Add(@"                                                   '======================'                          |              ");
            screen.Add(@"                                                   ||         ||         ||                          |              ");
            screen.Add(@"                                                   ||         ||         ||                          |              ");
            screen.Add(@"                                @@@@@@@@@          ||         ||         ||                          |              ");
            screen.Add(@"                              @@@@@@@@@@@@@        ||====================||                          |              ");
            screen.Add(@"                            @@@@@@@@@@@@@@@@       ||         ||         ||                          |              ");
            screen.Add(@"                            @__   @@@  __ @@       ||         ||         ||                          |              ");
            screen.Add(@"                            /  \ _____/  \ _       ||         ||         ||                          |              ");
            screen.Add(@"                          (| () |  | | () |@)      /======================\                          |              ");
            screen.Add(@"                            \__/   <  \__/@@       '----------------------'                          |              ");
            screen.Add(@"                              \    _    /|                                                           |              ");
            screen.Add(@"                               \_______/|                                                            |              ");
            screen.Add(@"__                               ___|___/___.                                                        |              ");
            screen.Add(@" /|                             /'  |><|     \                                                       |              ");
            screen.Add(@"/ |_____                       |  |  o     Y  |                                                      |              ");
            screen.Add(@"| /    /|                      |  |        |  |                                                      |              ");
            screen.Add(@"|/___ / |----------------------|__|  o     |__|------------------------------------------------------.              ");
            screen.Add(@"      | /                       |||         ||                                                        \             ");
            screen.Add(@"      |/                        |||  o      ||                                                         \            ");
            screen.Add(@"______/                         |||_________||                                                          \           ");
            screen.Add(@"                               '(('|   Y   '(('                                                          \          ");
            screen.Add(@"                                   |   |   |                                                              \         ");
            screen.Add(@"                                   |   |   |                                                               \        ");
            screen.Add(@"                                   |   |   |                                                                \       ");

            return screen;
        }

        public List<string> Screen2()
        {
            var screen = new List<string>();

            screen.Add(@"                                                   '======================'                          |              ");
            screen.Add(@"                                                   ||         ||         ||                          |              ");
            screen.Add(@"                                                   ||         ||         ||                          |              ");
            screen.Add(@"                                @@@@@@@@@          ||         ||         ||                          |              ");
            screen.Add(@"                              @@@@@@@@@@@@@        ||====================||                          |              ");
            screen.Add(@"                            @@@@@@@@@@@@@@@@       ||         ||         ||                          |              ");
            screen.Add(@"                            @__   @@@  __ @@       ||         ||         ||                          |              ");
            screen.Add(@"                            /  \ _____/  \ _       ||         ||         ||                          |              ");
            screen.Add(@"                          (| /\ |  | | /\ |@)      /======================\                          |              ");
            screen.Add(@"                            \__/   <  \__/@@       '----------------------'                          |              ");
            screen.Add(@"                              \    _    /|                                                           |              ");
            screen.Add(@"                               \_______/|                                                            |              ");
            screen.Add(@"__                       .lll.   ___|___/___.                                                        |              ");
            screen.Add(@" /|                       \ (/  /'  |><|     \                                                       |              ");
            screen.Add(@"/ |_____                   \\  /  Y  o     Y  |                                                      |              ");
            screen.Add(@"| /    /|                   \/Y  /|        |  |                                                      |              ");
            screen.Add(@"|/___ / |--------------------\__/-|  o     |__|------------------------------------------------------.              ");
            screen.Add(@"      | /                         |         ||                                                        \             ");
            screen.Add(@"      |/                          |  o      ||                                                         \            ");
            screen.Add(@"______/                           |_________||                                                          \           ");
            screen.Add(@"                                   |   Y   '(('                                                          \          ");
            screen.Add(@"                                   |   |   |                                                              \         ");
            screen.Add(@"                                   |   |   |                                                               \        ");
            screen.Add(@"                                   |   |   |                                                                \       ");

            return screen;
        }

    }
}
