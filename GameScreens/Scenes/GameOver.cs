using NGPlusPlus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGPlusPlus.GameScreensNamespace
{
    internal class GameOver : IGameScreen
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

            screen.Add(@" GGGGGGGGGGG AAAAAAAAA MMM     MMM EEEEEEEEEEEE   OOOOOOOOO VVV    VVV  EEEEEEEEEEE  RRRRRRRRRR ");
            screen.Add(@" GGGGGGGGGGG AAAAAAAAA MMMM   MMMM EEEEEEEEEEEE   OOOOOOOOO VVV    VVV  EEEEEEEEEEE  RRRRRRRRRR ");
            screen.Add(@" GGG     GGG AAA   AAA MMMMMMMMMMM EEE            OOO   OOO VVV    VVV  EEE          RRR    RRR ");
            screen.Add(@" GGG         AAA   AAA MMMMMMMMMMM EEE            OOO   OOO VVV    VVV  EEE          RRR    RRR ");
            screen.Add(@" GGG  GGGGGG AAAAAAAAA MMM MMM MMM EEEEEEE        OOO   OOO VVV    VVV  EEEEEEE      RRR    RR  ");
            screen.Add(@" GGG  GGGGGG AAAAAAAAA MMM MMM MMM EEEEEEE        OOO   OOO VVV    VVV  EEEEEEE      RRRRRRRR   ");
            screen.Add(@" GGG     GGG AAA   AAA MMM  M  MMM EEE            OOO   OOO VVV    VVV  EEE          RRRRRRRRR  ");
            screen.Add(@" GGG     GGG AAA   AAA MMM     MMM EEE            OOO   OOO  VVV  VVV   EEE          RRR    RRR ");
            screen.Add(@" GGGGGGGGGGG AAA   AAA MMM     MMM EEEEEEEEEEEE   OOOOOOOOO   VVVVVV    EEEEEEEEEEE  RRR    RRR ");
            screen.Add(@" GGGGGGGGGGG AAA   AAA MMM     MMM EEEEEEEEEEEE   OOOOOOOOO    VVVV     EEEEEEEEEEE  RRR    RRR ");
            return screen;
        }
    }
}
