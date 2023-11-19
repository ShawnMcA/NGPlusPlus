using RPGGame.Core;
using RPGGame.EnemyNamespace;
using RPGGame.Interfaces;
using RPGGame.PlayerNameSpace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame.GameScreensNamespace
{
    internal class FightScreen : IGameScreen
    {
        private Player Player;
        private Enemy Enemy1;
        public int AnimationSpeed => 100;
        public FightScreen(Enemy enemy1) 
        {
            Player = Player.GetInstance();
            Enemy1 = enemy1;
        }

        public List<List<string>> AnimationPackage()
        {
            var package = new List<List<string>>();

            package.Add(Screen1());

            return package;
        }

        public List<string> Screen1()
        {
            var screen = new List<string>();

            screen.Add(String.Format(@"                                                                                                                "));
            screen.Add(String.Format(@"                                                                                                                "));
            screen.Add(String.Format(@"                                                                                                                "));
            screen.Add(String.Format(@"                                                                                                                "));
            screen.Add(String.Format(@"                                                                                                                "));
            screen.Add(String.Format(@"                                                                                                                "));
            screen.Add(String.Format(@"                                                                                                                "));
            screen.Add(String.Format(@"                  ___________________________________________________________________________                   "));
            screen.Add(String.Format(@"                _/                                                                           \_                 "));
            screen.Add(String.Format(@"              _/                                                                               \_               "));
            screen.Add(String.Format(@"            _/                                                                                   \_             "));
            screen.Add(String.Format(@"          _/                                                                                       \_           "));
            screen.Add(String.Format(@"        _/                                                                                           \_         "));
            screen.Add(String.Format(@"      _/                                                                                               \_       "));
            screen.Add(String.Format(@"     /                                                                                                   \      "));
            screen.Add(String.Format(@"   .=======================================================================================================.    "));
            screen.Add(String.Format(@"   ||                              ||                                                                     ||    "));
            screen.Add(String.Format(@"   ||                              ||                                                                     ||    "));
            screen.Add(String.Format(@"   ||                              ||                                                                     ||    "));
            screen.Add(String.Format(@"   ||                              ||                                                                     ||    "));
            screen.Add(String.Format(@"   ||                              ||                                                                     ||    "));
            screen.Add(String.Format(@"   ||                              ||                                                                     ||    "));
            screen.Add(String.Format(@"   ||                              ||                                                                     ||    "));
            screen.Add(String.Format(@"   '======================================================================================================='    "));

            return screen;
        }
    }
}
