using NGPlusPlus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGPlusPlus.GameScreens.Core
{
    internal class BattleWonScreen : IGameScreen
    {
        public int AnimationSpeed => 300;
        public List<List<string>> AnimationPackage()
        {
            var package = new List<List<string>>();

            package.Add(Screen1());

            return package;
        }

        public List<string> Screen1()
        {
            var screen = new List<string>();

            screen.Add(@"                                                                                                                ");
            screen.Add(@"                                                                                                                ");
            screen.Add(@"                                                                                                                ");
            screen.Add(@"                                                                                                                ");
            screen.Add(@"     BBBBBBB  AAAAAAA TTTTTTTT TTTTTTTT LL      EEEEEEE     WW      WW  OOOOOOOOOO NN        NN  !!!  !!!       ");
            screen.Add(@"     BBBBBBB  AAAAAAA TTTTTTTT TTTTTTTT LL      EEEEEEE     WW      WW  OOOOOOOOOO NNN       NN  !!!  !!!       ");
            screen.Add(@"     BB  BBB  AA   AA    TT       TT    LL      EE          WW      WW  OO      OO NNNN      NN  !!!  !!!       ");
            screen.Add(@"     BB  BBB  AA   AA    TT       TT    LL      EE          WW      WW  OO      OO NN NN     NN  !!!  !!!       ");
            screen.Add(@"     BB  BB   AA   AA    TT       TT    LL      EE          WW      WW  OO      OO NN  NN    NN  !!!  !!!       ");
            screen.Add(@"     BBBBB    AAAAAAA    TT       TT    LL      EEEE        WW      WW  OO      OO NN   NN   NN  !!!  !!!       ");
            screen.Add(@"     BB  BB   AAAAAAA    TT       TT    LL      EEEE        WW  WW  WW  OO      OO NN    NN  NN  !!!  !!!       ");
            screen.Add(@"     BB  BBB  AA   AA    TT       TT    LL      EE          WW WWWW WW  OO      OO NN     NN NN  !!!  !!!       ");
            screen.Add(@"     BB  BBB  AA   AA    TT       TT    LL      EE          WWWW  WWWW  OO      OO NN      NNNN                 ");
            screen.Add(@"     BBBBBBB  AA   AA    TT       TT    LLLLLLL EEEEEEE     WWW    WWW  OOOOOOOOOO NN       NNN  !!!  !!!       ");
            screen.Add(@"     BBBBBB   AA   AA    TT       TT    LLLLLLL EEEEEEE     WW      WW  OOOOOOOOOO NN        NN  !!!  !!!       ");
            screen.Add(@"     ___________________________________________________________________________________________________        ");
            screen.Add(@"       ----------------------------------------------------------------------------------------------           ");
            screen.Add(@"                   - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -                        ");
            screen.Add(@"                                                                                                                ");
            screen.Add(@"                                                                                                                ");
            screen.Add(@"                                                                                                                ");
            screen.Add(@"                                                                                                                ");
            screen.Add(@"                                                                                                                ");
            screen.Add(@"                                                                                                                ");

            return screen;
        }
    }
}
