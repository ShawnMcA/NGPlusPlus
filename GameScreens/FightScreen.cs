using NGPlusPlus.Core;
using NGPlusPlus.EnemyNamespace;
using NGPlusPlus.Interfaces;

namespace NGPlusPlus.GameScreensNamespace
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
            screen.Add(String.Format(@"                                                                                                                    "));
            screen.Add(String.Format(@"                                                                                                                    "));
            screen.Add(String.Format(@"                                                                                                                    "));
            screen.Add(String.Format(@"                                                                                                                    "));
            screen.Add(String.Format(@"                                                                                                                    "));
            screen.Add(String.Format(@"                                                                                                                    "));
            screen.Add(String.Format(@"                                                                                                                    "));
            screen.Add(String.Format(@"                                                                                                                    "));
            screen.Add(String.Format(@"                    ____________________________________________________________________________                    "));
            screen.Add(String.Format(@"                  _/                                                                            \_                  "));
            screen.Add(String.Format(@"                _/                                                                                \_                "));
            screen.Add(String.Format(@"              _/                                                                                    \_              "));
            screen.Add(String.Format(@"            _/                                                                                        \_            "));
            screen.Add(String.Format(@"          _/                                                                                            \_          "));
            screen.Add(String.Format(@"        _/                                                                                                \_        "));
            screen.Add(String.Format(@"       /                                                                                                    \       "));
            screen.Add(String.Format(@"     .========================================================================================================.     "));
            screen.Add(String.Format(@"     ||                              ||                                                                      ||     "));
            screen.Add(String.Format(@"     ||                              ||                                                                      ||     "));
            screen.Add(String.Format(@"     ||                              ||                                                                      ||     "));
            screen.Add(String.Format(@"     ||                              ||                                                                      ||     "));
            screen.Add(String.Format(@"     ||                              ||                                                                      ||     "));
            screen.Add(String.Format(@"     ||                              ||                                                                      ||     "));
            screen.Add(String.Format(@"     ||                              ||                                                                      ||     "));
            screen.Add(String.Format(@"     '========================================================================================================'     "));
            screen.Add(String.Format(@"                                                                                                                    "));
            /*======================================================================================================================================================*/

            return screen;
        }
    }
}
