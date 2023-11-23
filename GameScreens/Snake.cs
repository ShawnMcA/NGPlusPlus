using NGPlusPlus.Core;
using NGPlusPlus.EnemyNamespace;
using NGPlusPlus.Interfaces;
using NGPlusPlus.PlayerNameSpace;

namespace NGPlusPlus.GameScreensNamespace
{
    internal class SnakeScreen : IGameScreen
    {
        private Enemy Enemy1;
        public int AnimationSpeed => 200;
        public SnakeScreen(Enemy enemy1) 
        {
            Enemy1 = enemy1;
        }

        public List<List<string>> AnimationPackage()
        {
            var package = new List<List<string>>
            {
                Screen1(),
                Screen2(),
                Screen3(),
                Screen4(),
                Screen5(),
                Screen6(),
                Screen7(),
                Screen7(),
                Screen8(),
                Screen9(),
                Screen1()
            };

            return package;
        }

        public List<string> Screen1()
        {
            var screen = new List<string>();

            /*===================================================================*/
            screen.Add(String.Format(@"                                        "));
            screen.Add(String.Format(@"                  ._____                "));
            screen.Add(String.Format(@"                _/ .. ...\              "));
            screen.Add(String.Format(@"              ./..../ ___.|             "));
            screen.Add(String.Format(@"             /     \  __../             "));
            screen.Add(String.Format(@"            ( |   | ) __./              "));
            screen.Add(String.Format(@"             \_____/ __./               "));
            screen.Add(String.Format(@"              '.^.'___./                "));
            screen.Add(String.Format(@"               ( )___.|                 "));
            screen.Add(String.Format(@"               |______.\                "));
            screen.Add(String.Format(@"                \______.\     o         "));
            screen.Add(String.Format(@"                 \______.\   ()        "));
            screen.Add(String.Format(@"        HP:  {0}/{1}{2}", Enemy1.Stats.Health.Current, Enemy1.Stats.Health.Max, Utilities.SpaceBuilder(Enemy1.Stats.Health.Current, Enemy1.Stats.Health.Max, 1, 26)));
            screen.Add(String.Format(@"        Lvl. {0} - {1}{2}", Enemy1.Level, Enemy1.Name, Utilities.SpaceBuilder(Enemy1.Level, Enemy1.Name, 3, 26)));
            /*===================================================================*/

            return screen;
        }

        public List<string> Screen2()
        {
            var screen = new List<string>();

            /*===================================================================*/
            screen.Add(String.Format(@"                                        "));
            screen.Add(String.Format(@"           _____________                "));
            screen.Add(String.Format(@"          /______________\              "));
            screen.Add(String.Format(@"          |..\     /......|             "));
            screen.Add(String.Format(@"          |../     \  _.../             "));
            screen.Add(String.Format(@"           \( |   | ) _../              "));
            screen.Add(String.Format(@"            \\_____/ __./               "));
            screen.Add(String.Format(@"             \'-|-'___./                "));
            screen.Add(String.Format(@"              \.^.___.|         o       "));
            screen.Add(String.Format(@"               ( )____.\       ()       "));
            screen.Add(String.Format(@"                \______.\      ()       "));
            screen.Add(String.Format(@"                 \______.\      \\      "));
            screen.Add(String.Format(@"        HP:  {0}/{1}{2}", Enemy1.Stats.Health.Current, Enemy1.Stats.Health.Max, Utilities.SpaceBuilder(Enemy1.Stats.Health.Current, Enemy1.Stats.Health.Max, 1, 26)));
            screen.Add(String.Format(@"        Lvl. {0} - {1}{2}", Enemy1.Level, Enemy1.Name, Utilities.SpaceBuilder(Enemy1.Level, Enemy1.Name, 3, 26)));
            /*===================================================================*/

            return screen;
        }

        public List<string> Screen3()
        {
            var screen = new List<string>();

            /*===================================================================*/
            screen.Add(String.Format(@"                                        "));
            screen.Add(String.Format(@"            ____________                "));
            screen.Add(String.Format(@"           /_/ ..__......\              "));
            screen.Add(String.Format(@"          |/..../____.....|             "));
            screen.Add(String.Format(@"         /     \______..../             "));
            screen.Add(String.Format(@"        ( |   | )_____.../              "));
            screen.Add(String.Format(@"         \_____/______../               "));
            screen.Add(String.Format(@"          '---'\______./                "));
            screen.Add(String.Format(@"               |_____.|                 "));
            screen.Add(String.Format(@"               |______.\      o         "));
            screen.Add(String.Format(@"                \______.\    ()         "));
            screen.Add(String.Format(@"                 \______.\   ()         "));
            screen.Add(String.Format(@"        HP:  {0}/{1}{2}", Enemy1.Stats.Health.Current, Enemy1.Stats.Health.Max, Utilities.SpaceBuilder(Enemy1.Stats.Health.Current, Enemy1.Stats.Health.Max, 1, 26)));
            screen.Add(String.Format(@"        Lvl. {0} - {1}{2}", Enemy1.Level, Enemy1.Name, Utilities.SpaceBuilder(Enemy1.Level, Enemy1.Name, 3, 26)));
            /*===================================================================*/

            return screen;
        }

        public List<string> Screen4()
        {
            var screen = new List<string>();

            /*===================================================================*/
            screen.Add(String.Format(@"                                        "));
            screen.Add(String.Format(@"       ___________________              "));
            screen.Add(String.Format(@"      /.../.........__.....\            "));
            screen.Add(String.Format(@"      |../......../____.....|           "));
            screen.Add(String.Format(@"      \./         \_____..../           "));
            screen.Add(String.Format(@"       \( |     | )_____.../            "));
            screen.Add(String.Format(@"         \_______/______../             "));
            screen.Add(String.Format(@"          '--|--' ______./              "));
            screen.Add(String.Format(@"            \| ________.|               "));
            screen.Add(String.Format(@"            .^.._______..\              "));
            screen.Add(String.Format(@"              |_________..\             "));
            screen.Add(String.Format(@"               \_________..\   o        "));
            screen.Add(String.Format(@"        HP:  {0}/{1}{2}", Enemy1.Stats.Health.Current, Enemy1.Stats.Health.Max, Utilities.SpaceBuilder(Enemy1.Stats.Health.Current, Enemy1.Stats.Health.Max, 1, 26)));
            screen.Add(String.Format(@"        Lvl. {0} - {1}{2}", Enemy1.Level, Enemy1.Name, Utilities.SpaceBuilder(Enemy1.Level, Enemy1.Name, 3, 26)));
            /*===================================================================*/

            return screen;
        }

        public List<string> Screen5()
        {
            var screen = new List<string>();

            /*===================================================================*/
            screen.Add(String.Format(@"     ___________________________        "));
            screen.Add(String.Format(@"    /...........................\       "));
            screen.Add(String.Format(@"   /......_..__________.._.......\      "));
            screen.Add(String.Format(@"  |...../__ /    ||    \ __\......|     "));
            screen.Add(String.Format(@"   \.../__ /  o      o  \ __\...../     "));
            screen.Add(String.Format(@"    \..|__ ( ==      == )__.|..../      "));
            screen.Add(String.Format(@"     \..\__ \__________/ __/..../       "));
            screen.Add(String.Format(@"      \..\__ ))  ()  (( __/..../        "));
            screen.Add(String.Format(@"       \..\__ \__||__/ __/.../          "));
            screen.Add(String.Format(@"        \..\___ /__\ ___/.../           "));
            screen.Add(String.Format(@"         |..\__________/...|            "));
            screen.Add(String.Format(@"         |...|_________|...|            "));
            screen.Add(String.Format(@"        HP:  {0}/{1}{2}", Enemy1.Stats.Health.Current, Enemy1.Stats.Health.Max, Utilities.SpaceBuilder(Enemy1.Stats.Health.Current, Enemy1.Stats.Health.Max, 1, 26)));
            screen.Add(String.Format(@"        Lvl. {0} - {1}{2}", Enemy1.Level, Enemy1.Name, Utilities.SpaceBuilder(Enemy1.Level, Enemy1.Name, 3, 26)));
            /*===================================================================*/

            return screen;
        }

        public List<string> Screen6()
        {
            var screen = new List<string>();

            /*===================================================================*/
            screen.Add(String.Format(@"                                        "));
            screen.Add(String.Format(@"                                        "));
            screen.Add(String.Format(@"________________________________________"));
            screen.Add(String.Format(@"     | |                       | |      "));
            screen.Add(String.Format(@"     | |                       | |      "));
            screen.Add(String.Format(@"     | |                       | |      "));
            screen.Add(String.Format(@"     | |                       | |      "));
            screen.Add(String.Format(@"_____\ |_______________________| /______"));
            screen.Add(String.Format(@"      \|       _______         |/       "));
            screen.Add(String.Format(@"              /  ___  \                ."));
            screen.Add(String.Format(@"             |  /   \  |              . "));
            screen.Add(String.Format(@"\..          |  | | |  |             /  "));
            screen.Add(String.Format(@"        HP:  {0}/{1}{2}", Enemy1.Stats.Health.Current, Enemy1.Stats.Health.Max, Utilities.SpaceBuilder(Enemy1.Stats.Health.Current, Enemy1.Stats.Health.Max, 1, 26)));
            screen.Add(String.Format(@"        Lvl. {0} - {1}{2}", Enemy1.Level, Enemy1.Name, Utilities.SpaceBuilder(Enemy1.Level, Enemy1.Name, 3, 26)));
            /*===================================================================*/

            return screen;
        }

        public List<string> Screen7()
        {
            var screen = new List<string>();

            /*===================================================================*/
            screen.Add(String.Format(@"                                        "));
            screen.Add(String.Format(@"                                        "));
            screen.Add(String.Format(@"                                        "));
            screen.Add(String.Format(@"                                        "));
            screen.Add(String.Format(@"                                        "));
            screen.Add(String.Format(@"                                        "));
            screen.Add(String.Format(@"                                        "));
            screen.Add(String.Format(@"                                        "));
            screen.Add(String.Format(@"                                        "));
            screen.Add(String.Format(@"                                        "));
            screen.Add(String.Format(@"                                        "));
            screen.Add(String.Format(@"                                        "));
            screen.Add(String.Format(@"        HP:  {0}/{1}{2}", Enemy1.Stats.Health.Current, Enemy1.Stats.Health.Max, Utilities.SpaceBuilder(Enemy1.Stats.Health.Current, Enemy1.Stats.Health.Max, 1, 26)));
            screen.Add(String.Format(@"        Lvl. {0} - {1}{2}", Enemy1.Level, Enemy1.Name, Utilities.SpaceBuilder(Enemy1.Level, Enemy1.Name, 3, 26)));
            /*===================================================================*/

            return screen;
        }

        public List<string> Screen8()
        {
            var screen = new List<string>();

            /*===================================================================*/
            screen.Add(String.Format(@"                                        "));
            screen.Add(String.Format(@"                                        "));
            screen.Add(String.Format(@"                                        "));
            screen.Add(String.Format(@"                                        "));
            screen.Add(String.Format(@"                                        "));
            screen.Add(String.Format(@"                                        "));
            screen.Add(String.Format(@"                                        "));
            screen.Add(String.Format(@"                  ._____                "));
            screen.Add(String.Format(@"                _/ .. ...\              "));
            screen.Add(String.Format(@"              ./..../ ___.|             "));
            screen.Add(String.Format(@"             /     \  __../             "));
            screen.Add(String.Format(@"            ( |   | ) __./              "));
            screen.Add(String.Format(@"        HP:  {0}/{1}{2}", Enemy1.Stats.Health.Current, Enemy1.Stats.Health.Max, Utilities.SpaceBuilder(Enemy1.Stats.Health.Current, Enemy1.Stats.Health.Max, 1, 26)));
            screen.Add(String.Format(@"        Lvl. {0} - {1}{2}", Enemy1.Level, Enemy1.Name, Utilities.SpaceBuilder(Enemy1.Level, Enemy1.Name, 3, 26)));
            /*===================================================================*/

            return screen;
        }

        public List<string> Screen9()
        {
            var screen = new List<string>();

            /*===================================================================*/
            screen.Add(String.Format(@"                                        "));
            screen.Add(String.Format(@"                                        "));
            screen.Add(String.Format(@"                                        "));
            screen.Add(String.Format(@"                                        "));
            screen.Add(String.Format(@"                  ._____                "));
            screen.Add(String.Format(@"                _/ .. ...\              "));
            screen.Add(String.Format(@"              ./..../ ___.|             "));
            screen.Add(String.Format(@"             /     \  __../             "));
            screen.Add(String.Format(@"            ( |   | ) __./              "));
            screen.Add(String.Format(@"             \_____/ __./               "));
            screen.Add(String.Format(@"              '.^.'___./                "));
            screen.Add(String.Format(@"               ( )___.|                 "));
            screen.Add(String.Format(@"        HP:  {0}/{1}{2}", Enemy1.Stats.Health.Current, Enemy1.Stats.Health.Max, Utilities.SpaceBuilder(Enemy1.Stats.Health.Current, Enemy1.Stats.Health.Max, 1, 26)));
            screen.Add(String.Format(@"        Lvl. {0} - {1}{2}", Enemy1.Level, Enemy1.Name, Utilities.SpaceBuilder(Enemy1.Level, Enemy1.Name, 3, 26)));
            /*===================================================================*/

            return screen;
        }
    }
}
