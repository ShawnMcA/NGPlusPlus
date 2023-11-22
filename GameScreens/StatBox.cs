using NGPlusPlus.Core;
using NGPlusPlus.EnemyNamespace;
using NGPlusPlus.Interfaces;
using NGPlusPlus.PlayerNameSpace;

namespace NGPlusPlus.GameScreensNamespace
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
            screen.Add(String.Format(@"  HP:    {0}/{1}{2}"          , Player.Stats.Health.Current, Player.Stats.Health.Max, Utilities.SpaceBuilder(Player.Stats.Health.Current, Player.Stats.Health.Max, 1, 21)));
            screen.Add(String.Format(@"  MP:    {0}/{1}{2}"          , Player.Stats.Mana.Current, Player.Stats.Mana.Max, Utilities.SpaceBuilder(Player.Stats.Mana.Current, Player.Stats.Mana.Max, 1, 21)));
            screen.Add(String.Format(@"  ATK:   {0}/{1}{2}"          , Player.Stats.Attack.Current, Player.Stats.Attack.Max, Utilities.SpaceBuilder(Player.Stats.Attack.Current, Player.Stats.Attack.Max, 1, 21)));
            screen.Add(String.Format(@"  DEF:   {0}/{1}{2}"          , Player.Stats.Defense.Current, Player.Stats.Defense.Max, Utilities.SpaceBuilder(Player.Stats.Defense.Current, Player.Stats.Defense.Max, 1, 21)));
            screen.Add(String.Format(@"  MATK:  {0}/{1}{2}"          , Player.Stats.MagicAttack.Current,  Player.Stats.MagicAttack.Max, Utilities.SpaceBuilder(Player.Stats.MagicAttack.Current, Player.Stats.MagicAttack.Max, 1, 21)));
            screen.Add(String.Format(@"  MDEF:  {0}/{1}{2}"          , Player.Stats.MagicDefense.Current, Player.Stats.MagicDefense.Max, Utilities.SpaceBuilder(Player.Stats.MagicDefense.Current, Player.Stats.MagicDefense.Max, 1, 21)));
            screen.Add(String.Format(@"  SPD:   {0}/{1}{2}"          , Player.Stats.Speed.Current, Player.Stats.Speed.Max, Utilities.SpaceBuilder(Player.Stats.Speed.Current, Player.Stats.Speed.Max, 1, 21)));
            /*========================================================*/

            return screen;
        }
    }
}
