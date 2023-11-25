using NGPlusPlus.Interfaces;

namespace NGPlusPlus.GameScreens.Scenes
{
    internal class AngryNpc1Screen : IGameScreen
    {
        public int AnimationSpeed => 600;
        public List<List<string>> AnimationPackage()
        {
            var package = new List<List<string>>
            {
                Screen1(),
                Screen2(),
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
            screen.Add(@"                            @     @@@     @@       ||         ||         ||                          |              ");
            screen.Add(@"                            __\\  ___ //__ _       ||         ||         ||                          |              ");
            screen.Add(@"                          (| o  \  | / o |@)      /======================\                          |              ");
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
            screen.Add(@"                            @     @@@     @@       ||         ||         ||                          |              ");
            screen.Add(@"                            __\\  ___ //__ _       ||         ||         ||                          |              ");
            screen.Add(@"                          (| o  \  | / o |@)      /======================\                          |              ");
            screen.Add(@"                            \__/   <  \__/@@       '----------------------'                          |              ");
            screen.Add(@"                              \   __    /|                                                           |              ");
            screen.Add(@"                               \_______/|                                                            |              ");
            screen.Add(@"__                               ___|___/___.                                                        |              ");
            screen.Add(@" /|                             /'  |><|     \                                                       |              ");
            screen.Add(@"/ |_____                       |  |  o     Y  |                                                      |              ");
            screen.Add(@"| /    /|                      |  \_n_____/   |                                                      |              ");
            screen.Add(@"|/___ / |---------------------- \__|___/__|__/ ------------------------------------------------------.              ");
            screen.Add(@"      | /                         |        |                                                          \             ");
            screen.Add(@"      |/                          |  o     |                                                           \            ");
            screen.Add(@"______/                           |________|                                                            \           ");
            screen.Add(@"                                   |   Y   |                                                             \          ");
            screen.Add(@"                                   |   |   |                                                              \         ");
            screen.Add(@"                                   |   |   |                                                               \        ");
            screen.Add(@"                                   |   |   |                                                                \       ");

            return screen;
        }

    }
}
