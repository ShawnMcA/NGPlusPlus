using NGPlusPlus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGPlusPlus.GameScreensNamespace
{
    internal class TitleScreen : IGameScreen
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

            screen.Add("                                                                                                                ");
            screen.Add("                                                                                                                ");
            screen.Add("                                                                                                                ");
            screen.Add("                       NNN          NNN  GGGGGGGGGGGGGGG                                                        ");
            screen.Add("                       NNNN         NNN  GGGGGGGGGGGGGGG                                                        ");
            screen.Add("                       NNNNN        NNN  GGG         GGG                                                        ");
            screen.Add("                       NNN NN       NNN  GGG                       +++             +++                          ");
            screen.Add("                       NNN  NN      NNN  GGG                       +++             +++                          ");
            screen.Add("                       NNN   NN     NNN  GGG                       +++             +++                          ");
            screen.Add("                       NNN    NN    NNN  GGG    GGGGGGGG      +++++++++++++   +++++++++++++                     ");
            screen.Add("                       NNN     NN   NNN  GGG    GGGGGGGG      +++++++++++++   +++++++++++++                     ");
            screen.Add("                       NNN      NN  NNN  GGG    GG   GGG           +++             +++                          ");
            screen.Add("                       NNN       NN NNN  GGG         GGG           +++             +++                          ");
            screen.Add("                       NNN        NNNNN  GGG         GGG           +++             +++                          ");
            screen.Add("                       NNN         NNNN  GGGGGGGGGGGGGGG                                                        ");
            screen.Add("                       NNN          NNN  GGGGGGGGGGGGGGG                                                        ");
            screen.Add("                                                                                                                ");
            screen.Add("                                                                                                                ");
            screen.Add("                                                                                                                ");
            screen.Add("                           A console based RPG              by Shawn McAllister 2023                            ");
            screen.Add("                                                                                                                ");
            screen.Add("                                                                                                                ");
            screen.Add("                                                                                                                ");
            screen.Add("                                                                                                                ");

            return screen;
        }
    }
}
