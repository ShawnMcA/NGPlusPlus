using NGPlusPlus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGPlusPlus.GameScreensNamespace
{
    internal class Template : IGameScreen
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
            screen.Add(@"                                                                                                                ");
            screen.Add(@"                                                                                                                ");
            screen.Add(@"                                                                                                                ");
            screen.Add(@"                                                                                                                ");
            screen.Add(@"                                                                                                                ");
            screen.Add(@"                                                                                                                ");
            screen.Add(@"                                                                                                                ");
            screen.Add(@"                                                                                                                ");
            screen.Add(@"                                                                                                                ");
            screen.Add(@"                                                                                                                ");
            screen.Add(@"                                                                                                                ");
            screen.Add(@"                                                                                                                ");
            screen.Add(@"                                                                                                                ");
            screen.Add(@"                                                                                                                ");
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
