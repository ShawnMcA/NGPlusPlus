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
    internal class Spider : IGameScreen
    {
        private Player Player;
        private Enemy Enemy1;
        public int AnimationSpeed => 100;
        public Spider(Enemy enemy1) 
        {
            Player = Player.GetInstance();
            Enemy1 = enemy1;
        }

        public List<List<string>> AnimationPackage()
        {
            var package = new List<List<string>>();

            package.Add(Screen1());
            package.Add(Screen4());
            package.Add(Screen5());
            package.Add(Screen4());
            package.Add(Screen1());
            package.Add(Screen2());
            package.Add(Screen3());
            package.Add(Screen2());
            package.Add(Screen1());

            return package;
        }

        public List<string> Screen1()
        {
            var screen = new List<string>();

            screen.Add(String.Format(@"                                                                                                                "));
            screen.Add(String.Format(@"                                                    ||                                                          "));
            screen.Add(String.Format(@"                                                    ||                                                          "));
            screen.Add(String.Format(@"                                                    ||                                                          "));
            screen.Add(String.Format(@"                                                    ||                                                          "));
            screen.Add(String.Format(@"                                               \ \ _||_ / /                                                     "));
            screen.Add(String.Format(@"                                                :>( >< )<:                                                      "));
            screen.Add(String.Format(@"                  __________________________   / / (..) \ \   _______________________________                   "));
            screen.Add(              @"                _/                                 {  }                                      \_                 ");
            screen.Add(String.Format(@"              _/                                                                               \_               "));
            screen.Add(String.Format(@"            _/                             HP:  {0}/{1}{2}\_             "                                           , Enemy1.CurrentHealth, Enemy1.MaxHealth, Utilities.SpaceBuilder(Enemy1.CurrentHealth, Enemy1.MaxHealth, 1, 49)));
            screen.Add(String.Format(@"          _/                               Lvl. {0} - {1}{2}\_           "                                           , Enemy1.Level, Enemy1.Name, Utilities.SpaceBuilder(Enemy1.Level, Enemy1.Name, 3, 51)));
            screen.Add(String.Format(@"        _/                                                                                           \_         "));
            screen.Add(String.Format(@"      _/                                                                                               \_       "));
            screen.Add(String.Format(@"     /                                                                                                   \      "));
            screen.Add(String.Format(@"   .=======================================================================================================.    "));
            screen.Add(String.Format(@"   ||  HP:   {0}/{1}{2}||                                                               ||    ", Player.CurrentHealth, Player.MaxHealth, Utilities.SpaceBuilder(Player.CurrentHealth, Player.MaxHealth, 1, 28)));
            screen.Add(String.Format(@"   ||  MP:   {0}/{1}{2}||    1) {3}{4}||    ",                                                   Player.CurrentMana, Player.MaxMana, Utilities.SpaceBuilder(Player.CurrentMana, Player.MaxMana, 1, 28), Player.Abilities[0].Name, Utilities.SpaceBuilder(Player.Abilities[0].Name, 0, 56)));
            screen.Add(String.Format(@"   ||  ATK:  {0}/{1}{2}||                                                               ||    ", Player.CurrentAttack, Player.Attack, Utilities.SpaceBuilder(Player.CurrentAttack, Player.Attack, 1, 28)));
            screen.Add(String.Format(@"   ||  DEF:  {0}/{1}{2}||    2) {3}{4}||    ",                                                   Player.CurrentDefense, Player.Defense, Utilities.SpaceBuilder(Player.CurrentDefense, Player.Defense, 1, 28), Player.Abilities[1].Name, Utilities.SpaceBuilder(Player.Abilities[1].Name, 0, 56)));
            screen.Add(String.Format(@"   ||  MATK: {0}/{1}{2}||                                                               ||    ", Player.CurrentMagicAttack, Player.MagicAttack, Utilities.SpaceBuilder(Player.CurrentMagicAttack, Player.MagicAttack, 1, 28)));
            screen.Add(String.Format(@"   ||  MDEF: {0}/{1}{2}||                                                               ||    ", Player.CurrentMagicDefense, Player.MagicDefense, Utilities.SpaceBuilder(Player.CurrentMagicDefense, Player.MagicDefense, 1, 28)));
            screen.Add(String.Format(@"   ||  SPD:  {0}/{1}{2}||                                                               ||    ", Player.CurrentSpeed, Player.CurrentSpeed, Utilities.SpaceBuilder(Player.CurrentSpeed, Player.CurrentSpeed, 1, 28)));
            screen.Add(String.Format(@"   '======================================================================================================='    "));

            return screen;
        }

        public List<string> Screen2()
        {
            var screen = new List<string>();

            screen.Add(String.Format(@"                                                                                                                "));
            screen.Add(String.Format(@"                                                    ||                                                          "));
            screen.Add(String.Format(@"                                                     ||                                                         "));
            screen.Add(String.Format(@"                                                      ||                                                        "));
            screen.Add(String.Format(@"                                                      ||                                                        "));
            screen.Add(String.Format(@"                                                  \ \ _||_ / /                                                  "));
            screen.Add(String.Format(@"                                                   :>( >< )<:                                                   "));
            screen.Add(String.Format(@"                  _____________________________   / / (..) \ \   ____________________________                   "));
            screen.Add(              @"                _/                                    {  }                                   \_                 ");
            screen.Add(String.Format(@"              _/                                                                               \_               "));
            screen.Add(String.Format(@"            _/                             HP:  {0}/{1}{2}\_             ", Enemy1.CurrentHealth, Enemy1.MaxHealth, Utilities.SpaceBuilder(Enemy1.CurrentHealth, Enemy1.MaxHealth, 1, 49)));
            screen.Add(String.Format(@"          _/                               Lvl. {0} - {1}{2}\_           ", Enemy1.Level, Enemy1.Name, Utilities.SpaceBuilder(Enemy1.Level, Enemy1.Name, 3, 51)));
            screen.Add(String.Format(@"        _/                                                                                           \_         "));
            screen.Add(String.Format(@"      _/                                                                                               \_       "));
            screen.Add(String.Format(@"     /                                                                                                   \      "));
            screen.Add(String.Format(@"   .=======================================================================================================.    "));
            screen.Add(String.Format(@"   ||  HP:   {0}/{1}{2}||                                                               ||    ", Player.CurrentHealth, Player.MaxHealth, Utilities.SpaceBuilder(Player.CurrentHealth, Player.MaxHealth, 1, 28)));
            screen.Add(String.Format(@"   ||  MP:   {0}/{1}{2}||    1) {3}{4}||    ", Player.CurrentMana, Player.MaxMana, Utilities.SpaceBuilder(Player.CurrentMana, Player.MaxMana, 1, 28), Player.Abilities[0].Name, Utilities.SpaceBuilder(Player.Abilities[0].Name, 0, 56)));
            screen.Add(String.Format(@"   ||  ATK:  {0}/{1}{2}||                                                               ||    ", Player.CurrentAttack, Player.Attack, Utilities.SpaceBuilder(Player.CurrentAttack, Player.Attack, 1, 28)));
            screen.Add(String.Format(@"   ||  DEF:  {0}/{1}{2}||    2) {3}{4}||    ", Player.CurrentDefense, Player.Defense, Utilities.SpaceBuilder(Player.CurrentDefense, Player.Defense, 1, 28), Player.Abilities[1].Name, Utilities.SpaceBuilder(Player.Abilities[1].Name, 0, 56)));
            screen.Add(String.Format(@"   ||  MATK: {0}/{1}{2}||                                                               ||    ", Player.CurrentMagicAttack, Player.MagicAttack, Utilities.SpaceBuilder(Player.CurrentMagicAttack, Player.MagicAttack, 1, 28)));
            screen.Add(String.Format(@"   ||  MDEF: {0}/{1}{2}||                                                               ||    ", Player.CurrentMagicDefense, Player.MagicDefense, Utilities.SpaceBuilder(Player.CurrentMagicDefense, Player.MagicDefense, 1, 28)));
            screen.Add(String.Format(@"   ||  SPD:  {0}/{1}{2}||                                                               ||    ", Player.CurrentSpeed, Player.CurrentSpeed, Utilities.SpaceBuilder(Player.CurrentSpeed, Player.CurrentSpeed, 1, 28)));
            screen.Add(String.Format(@"   '======================================================================================================='    "));

            return screen;
        }

        public List<string> Screen3()
        {
            var screen = new List<string>();

            screen.Add(String.Format(@"                                                                                                                "));
            screen.Add(String.Format(@"                                                    \\                                                          "));
            screen.Add(String.Format(@"                                                      \\                                                        "));
            screen.Add(String.Format(@"                                                       \\                                                       "));
            screen.Add(String.Format(@"                                                         \\                                                     "));
            screen.Add(String.Format(@"                                                     \ \ _||_ / /                                               "));
            screen.Add(String.Format(@"                                                      :>( >< )<:                                                "));
            screen.Add(String.Format(@"                  ________________________________   / / (..) \ \   _________________________                   "));
            screen.Add(              @"                _/                                       {  }                                \_                 ");
            screen.Add(String.Format(@"              _/                                                                               \_               "));
            screen.Add(String.Format(@"            _/                             HP:  {0}/{1}{2}\_             ", Enemy1.CurrentHealth, Enemy1.MaxHealth, Utilities.SpaceBuilder(Enemy1.CurrentHealth, Enemy1.MaxHealth, 1, 49)));
            screen.Add(String.Format(@"          _/                               Lvl. {0} - {1}{2}\_           ", Enemy1.Level, Enemy1.Name, Utilities.SpaceBuilder(Enemy1.Level, Enemy1.Name, 3, 51)));
            screen.Add(String.Format(@"        _/                                                                                           \_         "));
            screen.Add(String.Format(@"      _/                                                                                               \_       "));
            screen.Add(String.Format(@"     /                                                                                                   \      "));
            screen.Add(String.Format(@"   .=======================================================================================================.    "));
            screen.Add(String.Format(@"   ||  HP:   {0}/{1}{2}||                                                               ||    ", Player.CurrentHealth, Player.MaxHealth, Utilities.SpaceBuilder(Player.CurrentHealth, Player.MaxHealth, 1, 28)));
            screen.Add(String.Format(@"   ||  MP:   {0}/{1}{2}||    1) {3}{4}||    ", Player.CurrentMana, Player.MaxMana, Utilities.SpaceBuilder(Player.CurrentMana, Player.MaxMana, 1, 28), Player.Abilities[0].Name, Utilities.SpaceBuilder(Player.Abilities[0].Name, 0, 56)));
            screen.Add(String.Format(@"   ||  ATK:  {0}/{1}{2}||                                                               ||    ", Player.CurrentAttack, Player.Attack, Utilities.SpaceBuilder(Player.CurrentAttack, Player.Attack, 1, 28)));
            screen.Add(String.Format(@"   ||  DEF:  {0}/{1}{2}||    2) {3}{4}||    ", Player.CurrentDefense, Player.Defense, Utilities.SpaceBuilder(Player.CurrentDefense, Player.Defense, 1, 28), Player.Abilities[1].Name, Utilities.SpaceBuilder(Player.Abilities[1].Name, 0, 56)));
            screen.Add(String.Format(@"   ||  MATK: {0}/{1}{2}||                                                               ||    ", Player.CurrentMagicAttack, Player.MagicAttack, Utilities.SpaceBuilder(Player.CurrentMagicAttack, Player.MagicAttack, 1, 28)));
            screen.Add(String.Format(@"   ||  MDEF: {0}/{1}{2}||                                                               ||    ", Player.CurrentMagicDefense, Player.MagicDefense, Utilities.SpaceBuilder(Player.CurrentMagicDefense, Player.MagicDefense, 1, 28)));
            screen.Add(String.Format(@"   ||  SPD:  {0}/{1}{2}||                                                               ||    ", Player.CurrentSpeed, Player.CurrentSpeed, Utilities.SpaceBuilder(Player.CurrentSpeed, Player.CurrentSpeed, 1, 28)));
            screen.Add(String.Format(@"   '======================================================================================================='    "));

            return screen;
        }

        public List<string> Screen4()
        {
            var screen = new List<string>();

            screen.Add(String.Format(@"                                                                                                                "));
            screen.Add(String.Format(@"                                                    ||                                                          "));
            screen.Add(String.Format(@"                                                   ||                                                           "));
            screen.Add(String.Format(@"                                                  ||                                                            "));
            screen.Add(String.Format(@"                                                  ||                                                            "));
            screen.Add(String.Format(@"                                            \ \ _||_ / /                                                        "));
            screen.Add(String.Format(@"                                             :>( >< )<:                                                         "));
            screen.Add(String.Format(@"                  _______________________   / / (..) \ \   __________________________________                   "));
            screen.Add(              @"                _/                              {  }                                         \_                 ");
            screen.Add(String.Format(@"              _/                                                                               \_               "));
            screen.Add(String.Format(@"            _/                             HP:  {0}/{1}{2}\_             ", Enemy1.CurrentHealth, Enemy1.MaxHealth, Utilities.SpaceBuilder(Enemy1.CurrentHealth, Enemy1.MaxHealth, 1, 49)));
            screen.Add(String.Format(@"          _/                               Lvl. {0} - {1}{2}\_           ", Enemy1.Level, Enemy1.Name, Utilities.SpaceBuilder(Enemy1.Level, Enemy1.Name, 3, 51)));
            screen.Add(String.Format(@"        _/                                                                                           \_         "));
            screen.Add(String.Format(@"      _/                                                                                               \_       "));
            screen.Add(String.Format(@"     /                                                                                                   \      "));
            screen.Add(String.Format(@"   .=======================================================================================================.    "));
            screen.Add(String.Format(@"   ||  HP:   {0}/{1}{2}||                                                               ||    ", Player.CurrentHealth, Player.MaxHealth, Utilities.SpaceBuilder(Player.CurrentHealth, Player.MaxHealth, 1, 28)));
            screen.Add(String.Format(@"   ||  MP:   {0}/{1}{2}||    1) {3}{4}||    ", Player.CurrentMana, Player.MaxMana, Utilities.SpaceBuilder(Player.CurrentMana, Player.MaxMana, 1, 28), Player.Abilities[0].Name, Utilities.SpaceBuilder(Player.Abilities[0].Name, 0, 56)));
            screen.Add(String.Format(@"   ||  ATK:  {0}/{1}{2}||                                                               ||    ", Player.CurrentAttack, Player.Attack, Utilities.SpaceBuilder(Player.CurrentAttack, Player.Attack, 1, 28)));
            screen.Add(String.Format(@"   ||  DEF:  {0}/{1}{2}||    2) {3}{4}||    ", Player.CurrentDefense, Player.Defense, Utilities.SpaceBuilder(Player.CurrentDefense, Player.Defense, 1, 28), Player.Abilities[1].Name, Utilities.SpaceBuilder(Player.Abilities[1].Name, 0, 56)));
            screen.Add(String.Format(@"   ||  MATK: {0}/{1}{2}||                                                               ||    ", Player.CurrentMagicAttack, Player.MagicAttack, Utilities.SpaceBuilder(Player.CurrentMagicAttack, Player.MagicAttack, 1, 28)));
            screen.Add(String.Format(@"   ||  MDEF: {0}/{1}{2}||                                                               ||    ", Player.CurrentMagicDefense, Player.MagicDefense, Utilities.SpaceBuilder(Player.CurrentMagicDefense, Player.MagicDefense, 1, 28)));
            screen.Add(String.Format(@"   ||  SPD:  {0}/{1}{2}||                                                               ||    ", Player.CurrentSpeed, Player.CurrentSpeed, Utilities.SpaceBuilder(Player.CurrentSpeed, Player.CurrentSpeed, 1, 28)));
            screen.Add(String.Format(@"   '======================================================================================================='    "));

            return screen;
        }

        public List<string> Screen5()
        {
            var screen = new List<string>();

            screen.Add(String.Format(@"                                                                                                                "));
            screen.Add(String.Format(@"                                                    //                                                          "));
            screen.Add(String.Format(@"                                                  //                                                            "));
            screen.Add(String.Format(@"                                                 //                                                             "));
            screen.Add(String.Format(@"                                               //                                                               "));
            screen.Add(String.Format(@"                                         \ \ _||_ / /                                                           "));
            screen.Add(String.Format(@"                                          :>( >< )<:                                                            "));
            screen.Add(String.Format(@"                  ____________________   / / (..) \ \   _____________________________________                   "));
            screen.Add(              @"                _/                           {  }                                            \_                 ");
            screen.Add(String.Format(@"              _/                                                                               \_               "));
            screen.Add(String.Format(@"            _/                             HP:  {0}/{1}{2}\_             ", Enemy1.CurrentHealth, Enemy1.MaxHealth, Utilities.SpaceBuilder(Enemy1.CurrentHealth, Enemy1.MaxHealth, 1, 49)));
            screen.Add(String.Format(@"          _/                               Lvl. {0} - {1}{2}\_           ", Enemy1.Level, Enemy1.Name, Utilities.SpaceBuilder(Enemy1.Level, Enemy1.Name, 3, 51)));
            screen.Add(String.Format(@"        _/                                                                                           \_         "));
            screen.Add(String.Format(@"      _/                                                                                               \_       "));
            screen.Add(String.Format(@"     /                                                                                                   \      "));
            screen.Add(String.Format(@"   .=======================================================================================================.    "));
            screen.Add(String.Format(@"   ||  HP:   {0}/{1}{2}||                                                               ||    ", Player.CurrentHealth, Player.MaxHealth, Utilities.SpaceBuilder(Player.CurrentHealth, Player.MaxHealth, 1, 28)));
            screen.Add(String.Format(@"   ||  MP:   {0}/{1}{2}||    1) {3}{4}||    ", Player.CurrentMana, Player.MaxMana, Utilities.SpaceBuilder(Player.CurrentMana, Player.MaxMana, 1, 28), Player.Abilities[0].Name, Utilities.SpaceBuilder(Player.Abilities[0].Name, 0, 56)));
            screen.Add(String.Format(@"   ||  ATK:  {0}/{1}{2}||                                                               ||    ", Player.CurrentAttack, Player.Attack, Utilities.SpaceBuilder(Player.CurrentAttack, Player.Attack, 1, 28)));
            screen.Add(String.Format(@"   ||  DEF:  {0}/{1}{2}||    2) {3}{4}||    ", Player.CurrentDefense, Player.Defense, Utilities.SpaceBuilder(Player.CurrentDefense, Player.Defense, 1, 28), Player.Abilities[1].Name, Utilities.SpaceBuilder(Player.Abilities[1].Name, 0, 56)));
            screen.Add(String.Format(@"   ||  MATK: {0}/{1}{2}||                                                               ||    ", Player.CurrentMagicAttack, Player.MagicAttack, Utilities.SpaceBuilder(Player.CurrentMagicAttack, Player.MagicAttack, 1, 28)));
            screen.Add(String.Format(@"   ||  MDEF: {0}/{1}{2}||                                                               ||    ", Player.CurrentMagicDefense, Player.MagicDefense, Utilities.SpaceBuilder(Player.CurrentMagicDefense, Player.MagicDefense, 1, 28)));
            screen.Add(String.Format(@"   ||  SPD:  {0}/{1}{2}||                                                               ||    ", Player.CurrentSpeed, Player.CurrentSpeed, Utilities.SpaceBuilder(Player.CurrentSpeed, Player.CurrentSpeed, 1, 28)));
            screen.Add(String.Format(@"   '======================================================================================================='    "));

            return screen;
        }
    }
}
