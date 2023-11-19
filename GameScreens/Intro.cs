using RPGGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame.GameScreensNamespace
{
    internal class Intro : IGameScreen
    {
        public int AnimationSpeed => 300;
        public List<List<string>> AnimationPackage()
        {
            var package = new List<List<string>>();

            package.Add(Screen1());
            package.Add(Screen2());
            package.Add(Screen3());
            package.Add(Screen4());
            package.Add(Screen5());
            package.Add(Screen6());

            return package;
        }

        public List<string> Screen1()
        {
            var screen = new List<string>();

            screen.Add(@"                                                uuUUuUUUUuUUUuuUuUu                                                 ");
            screen.Add(@"                                                  uuUu\U UUuU/UuUu                                                  ");
            screen.Add(@"                                __                    uU  |.u/u                                                     ");
            screen.Add(@"                              /_  |         __         |  ./                                                        ");
            screen.Add(@"                             | |\ |        / _ \       |  |                                                         ");
            screen.Add(@"                              -  \ \      / / '-'      |  |                                                         ");
            screen.Add(@"                                 .   -----  .          |  |                                                         ");
            screen.Add(@"                                '             '        |  |                                                         ");
            screen.Add(@"                               '  o        @   '       |  |                ._________n__________.                   ");
            screen.Add(@"                               \               /       |  |                |                    |                   ");
            screen.Add(@"-----------------------------'.:      <       :-.'-----|  |----------------| Welcome to Nowhere |-------------------");
            screen.Add(@"                           ----_________________----   |  |                |____________________|                   ");
            screen.Add(@"                            -' \/\/\/\/\/\/\/\/ '-    .|..|.                         ||                             ");
            screen.Add(@"                                \_____________/      . .  .  .                       ||                             ");
            screen.Add(@"                                /     /|\     \                                      ||                             ");
            screen.Add(@"                               | __(.} | {.)__ |                                     ||                             ");
            screen.Add(@"                                \__(.} | {.)__/                                      ||                             ");
            screen.Add(@"                               (   (.} | {.)  )                                      ||                             ");
            screen.Add(@"                                /     \|/     \                                      ||                             ");
            screen.Add(@"                              ((('') xXXXx ('')))                                    ||                             ");
            screen.Add(@"  ===============================================================================================================   ");
            screen.Add(@"   -----  --------    ------------   ---------    ----------  -----------   ---------  ---------  --------- ---     ");
            screen.Add(@"====================================================================================================================");
            screen.Add(@"                                                                                                                    ");

            return screen;
        }

        public List<string> Screen2()
        {
            var screen = new List<string>();

            screen.Add(@"                                           uuUUuUUUUuUUUuuUuUu                                                      ");
            screen.Add(@"                                             uuUu\U UUuU/UuUu                                                       ");
            screen.Add(@"                           __                    uU  |.u/u                                                          ");
            screen.Add(@"                         /_  |         __         |  ./                                                             ");
            screen.Add(@"                        | |\ |        / _ \       |  |                                                              ");
            screen.Add(@"                         -  \ \      / / '-'      |  |                                                              ");
            screen.Add(@"                            .   -----  .          |  |                                                              ");
            screen.Add(@"                           '             '        |  |                                                              ");
            screen.Add(@"                          '  -        -   '       |  |                ._________n__________.                        ");
            screen.Add(@"                          \               /       |  |                |                    |                        ");
            screen.Add(@"------------------------'.:      >       :-.'-----|  |----------------| Welcome to Nowhere |------------------------");
            screen.Add(@"                      ----_________________----   |  |                |____________________|                        ");
            screen.Add(@"                       -' \/\/\/\/\/\/\/\/ '-    .|..|.                         ||                                  ");
            screen.Add(@"                           \_____________/      . .  .  .                       ||                                  ");
            screen.Add(@"                         /     /|  |\     \                                     ||                                  ");
            screen.Add(@"                        | __(.} |  | {.)__ |                                    ||                                  ");
            screen.Add(@"                         \__(.} | o| {.)__/                                     ||                                  ");
            screen.Add(@"                          ( (.} |  | {.) )                                      ||                                  ");
            screen.Add(@"                           /   \|  |/   \                                       ||                                  ");
            screen.Add(@"                         ((('') xXXXx ('')))                                    ||                                  ");
            screen.Add(@"  ===============================================================================================================   ");
            screen.Add(@"  -  --------    ------------   ---------    ----------  -----------   ---------  ---------  --------- ---   -----  ");
            screen.Add(@"====================================================================================================================");
            screen.Add(@"                                                                                                                    ");

            return screen;
        }

        public List<string> Screen3()
        {
            var screen = new List<string>();

            screen.Add(@"                          uuUUuUUUUuUUUuuUuUu                                                                     ");
            screen.Add(@"                            uuUu\U UUuU/UuUu                                                                        ");
            screen.Add(@"          __                    uU  |.u/u                                                                           ");
            screen.Add(@"        /_  |         __         |  ./                                                                              ");
            screen.Add(@"       | |\ |        / _ \       |  |                                                                               ");
            screen.Add(@"        -  \ \      / / '-'      |  |                                                                               ");
            screen.Add(@"           .   -----  .          |  |                                                                               ");
            screen.Add(@"          '             '        |  |                                                                               ");
            screen.Add(@"         '  @        o   '       |  |                ._________n__________.                                         ");
            screen.Add(@"         \               /       |  |                |                    |                                         ");
            screen.Add(@"-------'.:      >       :-.'-----|  |----------------| Welcome to Nowhere |-----------------------------------------");
            screen.Add(@"     ----_________________----   |  |                |____________________|                                         ");
            screen.Add(@"      -' \/\/\/\/\/\/\/\/ '-    .|..|.                         ||                                                   ");
            screen.Add(@"          \_____________/      . .  .  .                       ||                                                   ");
            screen.Add(@"          /     /|\     \                                      ||                                                   ");
            screen.Add(@"         | __(.} | {.)__ |                                     ||                                                   ");
            screen.Add(@"          \__(.} | {.)__/                                      ||                                                   ");
            screen.Add(@"         (   (.} | {.)  )                                      ||                                                   ");
            screen.Add(@"          /     \|/     \                                      ||                                                   ");
            screen.Add(@"        ((('') xXXXx ('')))                                    ||                                                   ");
            screen.Add(@"  ===============================================================================================================   ");
            screen.Add(@"  ---------    ----------  -----------   ---------  ---------  --------- ---   ------ --------- -----------  -----  ");
            screen.Add(@"====================================================================================================================");
            screen.Add(@"                                                                                                                    ");

            return screen;
        }

        public List<string> Screen4()
        {
            var screen = new List<string>();

            screen.Add(@"                 uuUUuUUUUuUUUuuUuUu                                                                                ");
            screen.Add(@"                 uuUu\U UUuU/UuUu                                                                                   ");
            screen.Add(@"                     uU  |.u/u                                                                                      ");
            screen.Add(@"                      |  ./                                                                                         ");
            screen.Add(@"                      |  |                                                                                          ");
            screen.Add(@"                      |  |                                                                                          ");
            screen.Add(@"                      |  |                                                                                          ");
            screen.Add(@"                      |  |                                                                                          ");
            screen.Add(@"                      |  |                ._________n__________.                                                    ");
            screen.Add(@"                      |  |                |                    |                                                    ");
            screen.Add(@"----------------------|  |----------------| Welcome to Nowhere |----------------------------------------------------");
            screen.Add(@"                      |  |                |____________________|                                                    ");
            screen.Add(@"                     .|..|.                         ||                                                              ");
            screen.Add(@"                    . .  .  .                       ||                                                              ");
            screen.Add(@"                                                    ||                                                              ");
            screen.Add(@"                                                    ||                                                              ");
            screen.Add(@"                                                    ||                                                              ");
            screen.Add(@"                                                    ||                                                              ");
            screen.Add(@"                                                    ||                                                              ");
            screen.Add(@"                                                    ||                                                              ");
            screen.Add(@"  ===============================================================================================================   ");
            screen.Add(@"-------   ---------  ---------  --------- ---   ------ --------- -----------  ------------  ----------   ---------  ");
            screen.Add(@"====================================================================================================================");
            screen.Add(@"                                                                                                                    ");

            return screen;
        }

        public List<string> Screen5()
        {
            var screen = new List<string>();

            screen.Add(@"      UUUuUuuUUUUuUUuUUUUUUuUUuUUuUUUUuUuuUUU                                                                       ");
            screen.Add(@"         UUUuuUUuuuUUUUuUUUUuuuUUUUUuUUUU                                                                           ");
            screen.Add(@"            UUUUUUUUUUUUUUUUUUUUUUUUUU                                                                              ");
            screen.Add(@"               UUUUu\U UUUU/UUUUUUUU                                                                                ");
            screen.Add(@"                UUuuUuU   |.u/u                                                                                     ");
            screen.Add(@"                   UUU|   ./                                                                                        ");
            screen.Add(@"                      |   |                                                                                         ");
            screen.Add(@"                      |   |                                                                                         ");
            screen.Add(@"                      |   |                          _                                                              ");
            screen.Add(@"                      |   |              .__________[_]___________.                                                 ");
            screen.Add(@"                      |   |              |                        |                                                 ");
            screen.Add(@"                      |   |              |                        |                                                 ");
            screen.Add(@"----------------------|   |--------------|   Welcome to Nowhere   |-------------------------------------------------");
            screen.Add(@"                      |   |              |                        |                                                 ");
            screen.Add(@"                      |   |              |________________________|                                                 ");
            screen.Add(@"                     .|.. |.                        | |                                                             ");
            screen.Add(@"                    . .  .  .                       | |                                                             ");
            screen.Add(@"                                                    | |                                                             ");
            screen.Add(@"                                                    | |                                                             ");
            screen.Add(@"                                                    | |                                                             ");
            screen.Add(@"                                                    | |                                                             ");
            screen.Add(@"                                                    | |                                                             ");
            screen.Add(@"                                                    | |                                                             ");
            screen.Add(@"                                                                                                                    ");

            return screen;
        }

        public List<string> Screen6()
        {
            var screen = new List<string>();

            screen.Add(@"                                              _____________                                                         ");
            screen.Add(@"                                             |             |                                                        ");
            screen.Add(@"      .______________________________________|_____________|_________________________________________________.      ");
            screen.Add(@"      |                                                                                                      |      ");
            screen.Add(@"      |                                                                                                      |      ");
            screen.Add(@"      |                                                                                                      |      ");
            screen.Add(@"      |                                                                                                      |      ");
            screen.Add(@"      |                                                                                                      |      ");
            screen.Add(@"      |    W     W        ll                             t                                                   |      ");
            screen.Add(@"      |    W     W        ll                             t                                                   |      ");
            screen.Add(@"      |    W     W        ll                             t                                                   |      ");
            screen.Add(@"      |    W     W  eeeee ll ccccc ooooo m   m eeeee   ttttt ooooo                                           |      ");
            screen.Add(@"------|    W     W  e   e ll c     o   o mm mm e   e     t   o   o                                           |------");
            screen.Add(@"      |    W  W  W  eeeee ll c     o   o m m m eeeee     t   o   o                                           |      ");
            screen.Add(@"      |    W W W W  e     ll c     o   o m   m e         t   o   o     xx  xx  xx  xx                        |      ");
            screen.Add(@"      |    WW   WW  eeeee ll ccccc ooooo m   m eeeee     t   ooooo     xx  xx  xx  xx                        |      ");
            screen.Add(@"      |                                                                                                      |      ");
            screen.Add(@"      |                                                                                                      |      ");
            screen.Add(@"      |                                                                                                      |      ");
            screen.Add(@"      |                                                                                                      |      ");
            screen.Add(@"      |                                                                                                      |      ");
            screen.Add(@"      '------------------------------------------------------------------------------------------------------'      ");
            screen.Add(@"                                             |             |                                                        ");
            screen.Add(@"                                             |             |                                                        ");

            return screen;
        }
    }
}
