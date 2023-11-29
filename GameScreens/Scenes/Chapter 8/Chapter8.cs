using NGPlusPlus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGPlusPlus.GameScreensNamespace
{
    internal class Chapter8Screen : IGameScreen
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
            screen.Add(string.Format(@"              CCCCCCCCC HHH   HHH AAAAAAAAA PPPPPPPPP TTTTTTTTT EEEEEEEEE RRRRRRRRR           888888888             "));
            screen.Add(string.Format(@"              CCCCCCCCC HHH   HHH AAAAAAAAA PPPPPPPPP TTTTTTTTT EEEEEEEEE RRRRRRRRR           888888888             "));
            screen.Add(string.Format(@"              CCC   CCC HHH   HHH AAA   AAA PPP   PPP    TTT    EEE       RRR   RRR           888   888             "));
            screen.Add(string.Format(@"              CCC       HHHHHHHHH AAAAAAAAA PPPPPPPP     TTT    EEEEEE    RRRRRRR             888888888             "));
            screen.Add(string.Format(@"              CCC       HHHHHHHHH AAAAAAAAA PPPPPP       TTT    EEEEEE    RRRRRR              888888888             "));
            screen.Add(string.Format(@"              CCC   CCC HHH   HHH AAA   AAA PPP          TTT    EEE       RRR  RRR            888   888             "));
            screen.Add(string.Format(@"              CCCCCCCCC HHH   HHH AAA   AAA PPP          TTT    EEEEEEEEE RRR   RRR           888888888             "));
            screen.Add(string.Format(@"              CCCCCCCCC HHH   HHH AAA   AAA PPP          TTT    EEEEEEEEE RRR   RRR           888888888             "));
            screen.Add(string.Format(@"             ___________________________________________________________________________________________            "));
            screen.Add(string.Format(@"                ====================================================================================                "));
            screen.Add(string.Format(@"                                                                                                                    "));
            screen.Add(string.Format(@"                                          Chapter 8: The Last Two Sages                                             "));
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
