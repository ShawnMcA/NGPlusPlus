using RPGGame.Core;
using RPGGame.EnemyNamespace;
using RPGGame.Interfaces;
using RPGGame.PlayerNameSpace;

namespace RPGGame.GameScreensNamespace
{
    internal class StatBox : IGameScreen
    {
        private Player Player;
        public int AnimationSpeed => 300;
        public StatBox() 
        {
            Player = Player.GetInstance();
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

            /*========================================================*/
            screen.Add(String.Format(@"  HP:    {0}/{1}{2}"          , Player.CurrentHealth,       Player.MaxHealth,    Utilities.SpaceBuilder(Player.CurrentHealth,       Player.MaxHealth,     1, 21)));
            screen.Add(String.Format(@"  MP:    {0}/{1}{2}"          , Player.CurrentMana,         Player.MaxMana,      Utilities.SpaceBuilder(Player.CurrentMana,         Player.MaxMana,       1, 21)));
            screen.Add(String.Format(@"  ATK:   {0}/{1}{2}"          , Player.CurrentAttack,       Player.Attack,       Utilities.SpaceBuilder(Player.CurrentAttack,       Player.Attack,        1, 21)));
            screen.Add(String.Format(@"  DEF:   {0}/{1}{2}"          , Player.CurrentDefense,      Player.Defense,      Utilities.SpaceBuilder(Player.CurrentDefense,      Player.Defense,       1, 21)));
            screen.Add(String.Format(@"  MATK:  {0}/{1}{2}"          , Player.CurrentMagicAttack,  Player.MagicAttack,  Utilities.SpaceBuilder(Player.CurrentMagicAttack,  Player.MagicAttack,   1, 21)));
            screen.Add(String.Format(@"  MDEF:  {0}/{1}{2}"          , Player.CurrentMagicDefense, Player.MagicDefense, Utilities.SpaceBuilder(Player.CurrentMagicDefense, Player.MagicDefense,  1, 21)));
            screen.Add(String.Format(@"  SPD:   {0}/{1}{2}"          , Player.CurrentSpeed,        Player.Speed,        Utilities.SpaceBuilder(Player.CurrentSpeed,        Player.Speed,         1, 21)));
            /*========================================================*/

            return screen;
        }
    }
}
