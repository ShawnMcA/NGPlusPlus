using NGPlusPlus.Core;
using NGPlusPlus.EnemyNamespace;
using NGPlusPlus.Interfaces;

namespace NGPlusPlus.GameScreens.Core
{
    internal class FightScreen : IGameScreen
    {
        public int AnimationSpeed => 100;

        public List<List<string>> AnimationPackage()
        {
            var package = new List<List<string>>();

            package.Add(Screen1());

            return package;
        }

        public List<string> Screen1()
        {
            var screen = new List<string>();

            /*======================================================================================================================================================*/
            screen.Add(string.Format(@"                                                                                                                    "));
            screen.Add(string.Format(@"                                                                                                                    "));
            screen.Add(string.Format(@"                                                                                                                    "));
            screen.Add(string.Format(@"                                                                                                                    "));
            screen.Add(string.Format(@"                                                                                                                    "));
            screen.Add(string.Format(@"                                                                                                                    "));
            screen.Add(string.Format(@"                                                                                                                    "));
            screen.Add(string.Format(@"                                                                                                                    "));
            screen.Add(string.Format(@"                    ____________________________________________________________________________                    "));
            screen.Add(string.Format(@"                  _/                                                                            \_                  "));
            screen.Add(string.Format(@"                _/                                                                                \_                "));
            screen.Add(string.Format(@"              _/                                                                                    \_              "));
            screen.Add(string.Format(@"            _/                                                                                        \_            "));
            screen.Add(string.Format(@"          _/                                                                                            \_          "));
            screen.Add(string.Format(@"        _/                                                                                                \_        "));
            screen.Add(string.Format(@"       /                                                                                                    \       "));
            screen.Add(string.Format(@"     .========================================================================================================.     "));
            screen.Add(string.Format(@"     ||                              ||                                                                      ||     "));
            screen.Add(string.Format(@"     ||                              ||                                                                      ||     "));
            screen.Add(string.Format(@"     ||                              ||                                                                      ||     "));
            screen.Add(string.Format(@"     ||                              ||                                                                      ||     "));
            screen.Add(string.Format(@"     ||                              ||                                                                      ||     "));
            screen.Add(string.Format(@"     ||                              ||                                                                      ||     "));
            screen.Add(string.Format(@"     ||                              ||                                                                      ||     "));
            screen.Add(string.Format(@"     '========================================================================================================'     "));
            screen.Add(string.Format(@"                                                                                                                    "));
            /*======================================================================================================================================================*/

            return screen;
        }
    }
}
