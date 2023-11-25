using NGPlusPlus.Core;
using NGPlusPlus.EnemyNamespace;
using NGPlusPlus.Interfaces;
using NGPlusPlus.PlayerNameSpace;

namespace NGPlusPlus.GameScreens.Enemies
{
    internal class RatScreen : IGameScreen
    {
        private Enemy Enemy1;
        public int AnimationSpeed => 100;
        public RatScreen(Enemy enemy1)
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
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"               nn _                     "));
            screen.Add(string.Format(@"            o<(')(_)-._                 "));
            screen.Add(string.Format(@"                ' '                     "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"        HP:  {0}/{1}{2}", Enemy1.Stats.Health.Current, Enemy1.Stats.Health.Max, Utilities.SpaceBuilder(Enemy1.Stats.Health.Current, Enemy1.Stats.Health.Max, 1, 26)));
            screen.Add(string.Format(@"        Lvl. {0} - {1}{2}", Enemy1.Level, Enemy1.Name, Utilities.SpaceBuilder(Enemy1.Level, Enemy1.Name, 3, 26)));
            /*===================================================================*/

            return screen;
        }

        public List<string> Screen2()
        {
            var screen = new List<string>();

            /*===================================================================*/
            screen.Add(string.Format(@"        .                               "));
            screen.Add(string.Format(@"       /o\                              "));
            screen.Add(string.Format(@"      (o_O)                             "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"               nn _                     "));
            screen.Add(string.Format(@"            o<(')(_)-._                 "));
            screen.Add(string.Format(@"                ' '                     "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"        HP:  {0}/{1}{2}", Enemy1.Stats.Health.Current, Enemy1.Stats.Health.Max, Utilities.SpaceBuilder(Enemy1.Stats.Health.Current, Enemy1.Stats.Health.Max, 1, 26)));
            screen.Add(string.Format(@"        Lvl. {0} - {1}{2}", Enemy1.Level, Enemy1.Name, Utilities.SpaceBuilder(Enemy1.Level, Enemy1.Name, 3, 26)));
            /*===================================================================*/

            return screen;
        }

        public List<string> Screen3()
        {
            var screen = new List<string>();

            /*===================================================================*/
            screen.Add(string.Format(@"        '                               "));
            screen.Add(string.Format(@"        .                               "));
            screen.Add(string.Format(@"        '                               "));
            screen.Add(string.Format(@"        .                               "));
            screen.Add(string.Format(@"       /o\                              "));
            screen.Add(string.Format(@"      (o_O)                             "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"               nn _                     "));
            screen.Add(string.Format(@"            o<(')(_)-._                 "));
            screen.Add(string.Format(@"                ' '                     "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"        HP:  {0}/{1}{2}", Enemy1.Stats.Health.Current, Enemy1.Stats.Health.Max, Utilities.SpaceBuilder(Enemy1.Stats.Health.Current, Enemy1.Stats.Health.Max, 1, 26)));
            screen.Add(string.Format(@"        Lvl. {0} - {1}{2}", Enemy1.Level, Enemy1.Name, Utilities.SpaceBuilder(Enemy1.Level, Enemy1.Name, 3, 26)));
            /*===================================================================*/

            return screen;
        }

        public List<string> Screen4()
        {
            var screen = new List<string>();

            /*===================================================================*/
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"        '                               "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"        |                               "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"        '                               "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"        .      nn _                     "));
            screen.Add(string.Format(@"       /o\  o<(')(_)-._                 "));
            screen.Add(string.Format(@"      (o_O)     ' '                     "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"        HP:  {0}/{1}{2}", Enemy1.Stats.Health.Current, Enemy1.Stats.Health.Max, Utilities.SpaceBuilder(Enemy1.Stats.Health.Current, Enemy1.Stats.Health.Max, 1, 26)));
            screen.Add(string.Format(@"        Lvl. {0} - {1}{2}", Enemy1.Level, Enemy1.Name, Utilities.SpaceBuilder(Enemy1.Level, Enemy1.Name, 3, 26)));
            /*===================================================================*/

            return screen;
        }

        public List<string> Screen5()
        {
            var screen = new List<string>();

            /*===================================================================*/
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"        .      nn _                     "));
            screen.Add(string.Format(@"       /o\  o<(')(_)-._                 "));
            screen.Add(string.Format(@"      (o_O)     ' '                     "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"        HP:  {0}/{1}{2}", Enemy1.Stats.Health.Current, Enemy1.Stats.Health.Max, Utilities.SpaceBuilder(Enemy1.Stats.Health.Current, Enemy1.Stats.Health.Max, 1, 26)));
            screen.Add(string.Format(@"        Lvl. {0} - {1}{2}", Enemy1.Level, Enemy1.Name, Utilities.SpaceBuilder(Enemy1.Level, Enemy1.Name, 3, 26)));
            /*===================================================================*/

            return screen;
        }

        public List<string> Screen6()
        {
            var screen = new List<string>();

            /*===================================================================*/
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"  .      nn _                           "));
            screen.Add(string.Format(@" /o\  o<(')(_)-._                       "));
            screen.Add(string.Format(@"(o_O)     ' '                           "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"        HP:  {0}/{1}{2}", Enemy1.Stats.Health.Current, Enemy1.Stats.Health.Max, Utilities.SpaceBuilder(Enemy1.Stats.Health.Current, Enemy1.Stats.Health.Max, 1, 26)));
            screen.Add(string.Format(@"        Lvl. {0} - {1}{2}", Enemy1.Level, Enemy1.Name, Utilities.SpaceBuilder(Enemy1.Level, Enemy1.Name, 3, 26)));
            /*===================================================================*/

            return screen;
        }

        public List<string> Screen7()
        {
            var screen = new List<string>();

            /*===================================================================*/
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@")-._                                    "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"        HP:  {0}/{1}{2}", Enemy1.Stats.Health.Current, Enemy1.Stats.Health.Max, Utilities.SpaceBuilder(Enemy1.Stats.Health.Current, Enemy1.Stats.Health.Max, 1, 26)));
            screen.Add(string.Format(@"        Lvl. {0} - {1}{2}", Enemy1.Level, Enemy1.Name, Utilities.SpaceBuilder(Enemy1.Level, Enemy1.Name, 3, 26)));
            /*===================================================================*/

            return screen;
        }

        public List<string> Screen8()
        {
            var screen = new List<string>();


            /*===================================================================*/
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"                                    nn _"));
            screen.Add(string.Format(@"                                 o<(')(_"));
            screen.Add(string.Format(@"                                     ' '"));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"        HP:  {0}/{1}{2}", Enemy1.Stats.Health.Current, Enemy1.Stats.Health.Max, Utilities.SpaceBuilder(Enemy1.Stats.Health.Current, Enemy1.Stats.Health.Max, 1, 26)));
            screen.Add(string.Format(@"        Lvl. {0} - {1}{2}", Enemy1.Level, Enemy1.Name, Utilities.SpaceBuilder(Enemy1.Level, Enemy1.Name, 3, 26)));
            /*===================================================================*/

            return screen;
        }

        public List<string> Screen9()
        {
            var screen = new List<string>();

            /*===================================================================*/
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"                          nn _          "));
            screen.Add(string.Format(@"                       o<(')(_)-._      "));
            screen.Add(string.Format(@"                           ' '          "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"                                        "));
            screen.Add(string.Format(@"        HP:  {0}/{1}{2}", Enemy1.Stats.Health.Current, Enemy1.Stats.Health.Max, Utilities.SpaceBuilder(Enemy1.Stats.Health.Current, Enemy1.Stats.Health.Max, 1, 26)));
            screen.Add(string.Format(@"        Lvl. {0} - {1}{2}", Enemy1.Level, Enemy1.Name, Utilities.SpaceBuilder(Enemy1.Level, Enemy1.Name, 3, 26)));
            /*===================================================================*/

            return screen;
        }
    }
}
