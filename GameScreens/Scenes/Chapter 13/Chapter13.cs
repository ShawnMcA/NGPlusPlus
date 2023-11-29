using NGPlusPlus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGPlusPlus.GameScreensNamespace
{
    internal class Chapter13Screen : IGameScreen
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

            /*======================================================================================================================================================*/
            screen.Add(string.Format(@"                                                                                                                    "));
            screen.Add(string.Format(@"                                                                                                                    "));
            screen.Add(string.Format(@"                                                                                                                    "));
            screen.Add(string.Format(@"                                                                                                                    "));
            screen.Add(string.Format(@"                                                                                                                    "));
            screen.Add(string.Format(@"                                                                                                                    "));
            screen.Add(string.Format(@"                                                                                                                    "));
            screen.Add(string.Format(@"              CCCCCCCCC HHH   HHH AAAAAAAAA PPPPPPPPP TTTTTTTTT EEEEEEEEE RRRRRRRRR      1111 333333333             "));
            screen.Add(string.Format(@"              CCCCCCCCC HHH   HHH AAAAAAAAA PPPPPPPPP TTTTTTTTT EEEEEEEEE RRRRRRRRR    111111 333333333             "));
            screen.Add(string.Format(@"              CCC   CCC HHH   HHH AAA   AAA PPP   PPP    TTT    EEE       RRR   RRR       111       333             "));
            screen.Add(string.Format(@"              CCC       HHHHHHHHH AAAAAAAAA PPPPPPPP     TTT    EEEEEE    RRRRRRR         111    333333             "));
            screen.Add(string.Format(@"              CCC       HHHHHHHHH AAAAAAAAA PPPPPP       TTT    EEEEEE    RRRRRR          111    333333             "));
            screen.Add(string.Format(@"              CCC   CCC HHH   HHH AAA   AAA PPP          TTT    EEE       RRR  RRR        111       333             "));
            screen.Add(string.Format(@"              CCCCCCCCC HHH   HHH AAA   AAA PPP          TTT    EEEEEEEEE RRR   RRR       111 333333333             "));
            screen.Add(string.Format(@"              CCCCCCCCC HHH   HHH AAA   AAA PPP          TTT    EEEEEEEEE RRR   RRR       111 333333333             "));
            screen.Add(string.Format(@"             ___________________________________________________________________________________________            "));
            screen.Add(string.Format(@"                ====================================================================================                "));
            screen.Add(string.Format(@"                                                                                                                    "));
            screen.Add(string.Format(@"                                          Final Chapter: The Real World                                             "));
            screen.Add(string.Format(@"                                                                                                                    "));
            screen.Add(string.Format(@"                                                                                                                    "));
            screen.Add(string.Format(@"                                                                                                                    "));
            screen.Add(string.Format(@"                                                                                                                    "));
            screen.Add(string.Format(@"                                                                                                                    "));
            screen.Add(string.Format(@"                                                                                                                    "));
            screen.Add(string.Format(@"                                                                                                                    "));
            /*======================================================================================================================================================*/

            return screen;
        }
    }
}
