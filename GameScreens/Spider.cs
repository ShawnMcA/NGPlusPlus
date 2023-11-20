﻿using RPGGame.Core;
using RPGGame.EnemyNamespace;
using RPGGame.Interfaces;
using RPGGame.PlayerNameSpace;

namespace RPGGame.GameScreensNamespace
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
            var package = new List<List<string>>();

            package.Add(Screen1());
            package.Add(Screen4());
            package.Add(Screen5());
            package.Add(Screen4());
            package.Add(Screen1());
            package.Add(Screen2());
            package.Add(Screen3());
            package.Add(Screen2());
            package.Add(Screen1());

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
            screen.Add(String.Format(@"        HP:  {0}/{1}{2}"                , Enemy1.CurrentHealth, Enemy1.MaxHealth, Utilities.SpaceBuilder(Enemy1.CurrentHealth, Enemy1.MaxHealth, 1, 26)));
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
            screen.Add(String.Format(@"        HP:  {0}/{1}{2}"                 , Enemy1.CurrentHealth, Enemy1.MaxHealth, Utilities.SpaceBuilder(Enemy1.CurrentHealth, Enemy1.MaxHealth, 1, 26)));
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
            screen.Add(String.Format(@"        HP:  {0}/{1}{2}"                 , Enemy1.CurrentHealth, Enemy1.MaxHealth, Utilities.SpaceBuilder(Enemy1.CurrentHealth, Enemy1.MaxHealth, 1, 26)));
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
            screen.Add(String.Format(@"        HP:  {0}/{1}{2}"                 , Enemy1.CurrentHealth, Enemy1.MaxHealth, Utilities.SpaceBuilder(Enemy1.CurrentHealth, Enemy1.MaxHealth, 1, 26)));
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
            screen.Add(String.Format(@"        HP:  {0}/{1}{2}"                 , Enemy1.CurrentHealth, Enemy1.MaxHealth, Utilities.SpaceBuilder(Enemy1.CurrentHealth, Enemy1.MaxHealth, 1, 26)));
            screen.Add(String.Format(@"        Lvl. {0} - {1}{2}"               , Enemy1.Level, Enemy1.Name, Utilities.SpaceBuilder(Enemy1.Level, Enemy1.Name, 3, 26)));
            /*===================================================================*/

            return screen;
        }
    }
}
