using NGPlusPlus.Core;
using NGPlusPlus.EnemyNamespace;
using NGPlusPlus.Interfaces;

namespace NGPlusPlus.GameScreensNamespace
{
    internal class SpiderScreen : IGameScreen
    {
        private Enemy Enemy1;
        public int AnimationSpeed => 100;
        public SpiderScreen(Enemy enemy1) 
        {
            Enemy1 = enemy1;
        }

        public List<List<string>> AnimationPackage()
        {
            var package = new List<List<string>>
            {
                Screen1(),
                Screen4(),
                Screen5(),
                Screen4(),
                Screen1(),
                Screen2(),
                Screen3(),
                Screen2(),
                Screen1()
            };

            return package;
        }

        public List<string> Screen1()
        {
            var screen = new List<string>();

            /*===================================================================*/
            screen.Add(String.Format(@"                                        "));
            screen.Add(String.Format(@"                  ||                    "));
            screen.Add(String.Format(@"                  ||                    "));
            screen.Add(String.Format(@"                  ||                    "));
            screen.Add(String.Format(@"                  ||                    "));
            screen.Add(String.Format(@"             \ \ _||_ / /               "));
            screen.Add(String.Format(@"              :>( >< )<:                "));
            screen.Add(String.Format(@"             / / (..) \ \               "));
            screen.Add(              @"                  {}                    " );
            screen.Add(String.Format(@"                                        "));
            screen.Add(String.Format(@"                                        "));
            screen.Add(String.Format(@"                                        "));
            screen.Add(String.Format(@"        HP:  {0}/{1}{2}"                , Enemy1.Stats.Health.Current, Enemy1.Stats.Health.Max, Utilities.SpaceBuilder(Enemy1.Stats.Health.Current, Enemy1.Stats.Health.Max, 1, 26)));
            screen.Add(String.Format(@"        Lvl. {0} - {1}{2}"              , Enemy1.Level, Enemy1.Name, Utilities.SpaceBuilder(Enemy1.Level, Enemy1.Name, 3, 26)));
            /*===================================================================*/

            return screen;
        }

        public List<string> Screen2()
        {
            var screen = new List<string>();


            /*===================================================================*/
            screen.Add(String.Format(@"                                        "));
            screen.Add(String.Format(@"                  ||                    "));
            screen.Add(String.Format(@"                   ||                   "));
            screen.Add(String.Format(@"                    ||                  "));
            screen.Add(String.Format(@"                    ||                  "));
            screen.Add(String.Format(@"                \ \ _||_ / /            "));
            screen.Add(String.Format(@"                 :>( >< )<:             "));
            screen.Add(String.Format(@"                / / (..) \ \            "));
            screen.Add(              @"                    {  }                " );
            screen.Add(String.Format(@"                                        "));
            screen.Add(String.Format(@"                                        "));
            screen.Add(String.Format(@"                                        "));
            screen.Add(String.Format(@"        HP:  {0}/{1}{2}"                 , Enemy1.Stats.Health.Current, Enemy1.Stats.Health.Max, Utilities.SpaceBuilder(Enemy1.Stats.Health.Current, Enemy1.Stats.Health.Max, 1, 26)));
            screen.Add(String.Format(@"        Lvl. {0} - {1}{2}"               , Enemy1.Level, Enemy1.Name, Utilities.SpaceBuilder(Enemy1.Level, Enemy1.Name, 3, 26)));
            /*===================================================================*/

            return screen;
        }

        public List<string> Screen3()
        {
            var screen = new List<string>();

            /*===================================================================*/
            screen.Add(String.Format(@"                                        "));
            screen.Add(String.Format(@"                  \\                    "));
            screen.Add(String.Format(@"                    \\                  "));
            screen.Add(String.Format(@"                     \\                 "));
            screen.Add(String.Format(@"                       \\               "));
            screen.Add(String.Format(@"                   \ \ _||_ / /         "));
            screen.Add(String.Format(@"                    :>( >< )<:          "));
            screen.Add(String.Format(@"                   / / (..) \ \         "));
            screen.Add(              @"                        {}              " );
            screen.Add(String.Format(@"                                        "));
            screen.Add(String.Format(@"                                        "));
            screen.Add(String.Format(@"                                        "));
            screen.Add(String.Format(@"        HP:  {0}/{1}{2}", Enemy1.Stats.Health.Current, Enemy1.Stats.Health.Max, Utilities.SpaceBuilder(Enemy1.Stats.Health.Current, Enemy1.Stats.Health.Max, 1, 26)));
            screen.Add(String.Format(@"        Lvl. {0} - {1}{2}"               , Enemy1.Level, Enemy1.Name, Utilities.SpaceBuilder(Enemy1.Level, Enemy1.Name, 3, 26)));
            /*===================================================================*/

            return screen;
        }

        public List<string> Screen4()
        {
            var screen = new List<string>();


            /*===================================================================*/
            screen.Add(String.Format(@"                                        "));
            screen.Add(String.Format(@"                  ||                    "));
            screen.Add(String.Format(@"                 ||                     "));
            screen.Add(String.Format(@"                ||                      "));
            screen.Add(String.Format(@"                ||                      "));
            screen.Add(String.Format(@"          \ \ _||_ / /                  "));
            screen.Add(String.Format(@"           :>( >< )<:                   "));
            screen.Add(String.Format(@"          / / (..) \ \                  "));
            screen.Add(              @"              {  }                      " );
            screen.Add(String.Format(@"                                        "));
            screen.Add(String.Format(@"                                        "));
            screen.Add(String.Format(@"                                        "));
            screen.Add(String.Format(@"        HP:  {0}/{1}{2}", Enemy1.Stats.Health.Current, Enemy1.Stats.Health.Max, Utilities.SpaceBuilder(Enemy1.Stats.Health.Current, Enemy1.Stats.Health.Max, 1, 26)));
            screen.Add(String.Format(@"        Lvl. {0} - {1}{2}"               , Enemy1.Level, Enemy1.Name, Utilities.SpaceBuilder(Enemy1.Level, Enemy1.Name, 3, 26)));
            /*===================================================================*/

            return screen;
        }

        public List<string> Screen5()
        {
            var screen = new List<string>();

            /*===================================================================*/
            screen.Add(String.Format(@"                                        "));
            screen.Add(String.Format(@"                  //                    "));
            screen.Add(String.Format(@"                //                      "));
            screen.Add(String.Format(@"               //                       "));
            screen.Add(String.Format(@"             //                         "));
            screen.Add(String.Format(@"       \ \ _||_ / /                     "));
            screen.Add(String.Format(@"        :>( >< )<:                      "));
            screen.Add(String.Format(@"       / / (..) \ \                     "));
            screen.Add(              @"            {}                          " );
            screen.Add(String.Format(@"                                        "));
            screen.Add(String.Format(@"                                        "));
            screen.Add(String.Format(@"                                        "));
            screen.Add(String.Format(@"        HP:  {0}/{1}{2}", Enemy1.Stats.Health.Current, Enemy1.Stats.Health.Max, Utilities.SpaceBuilder(Enemy1.Stats.Health.Current, Enemy1.Stats.Health.Max, 1, 26)));
            screen.Add(String.Format(@"        Lvl. {0} - {1}{2}"               , Enemy1.Level, Enemy1.Name, Utilities.SpaceBuilder(Enemy1.Level, Enemy1.Name, 3, 26)));
            /*===================================================================*/

            return screen;
        }
    }
}
