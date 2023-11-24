using NGPlusPlus.Core;
using NGPlusPlus.EnemyNamespace;
using NGPlusPlus.Interfaces;
using NGPlusPlus.PlayerNameSpace;

namespace NGPlusPlus.GameScreensNamespace
{
    internal class AbilityMenu : IGameScreen
    {
        private Player Player;
        public int AnimationSpeed => 300;
        public AbilityMenu() 
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

            var str1 = $"{Player.Abilities[0].Name} ({Player.Abilities[0].ManaCost} MP)";
            var str2 = $"{Player.Abilities[1].Name} ({Player.Abilities[1].ManaCost} MP)";
            var str3 = Player.Abilities.Count < 3 ? "" : $"{Player.Abilities[2].Name} ({Player.Abilities[2].ManaCost} MP)";

            /*========================================================*/
            screen.Add(String.Format(@"                                                                      "));
            screen.Add(String.Format(@"  1) {0}{1}"                                                          , str1, Utilities.SpaceBuilder(str1, 0, 65)));
            screen.Add(String.Format(@"                                                                      "));
            screen.Add(String.Format(@"  2) {0}{1}"                                                          , str2, Utilities.SpaceBuilder(str2, 0, 65)));
            screen.Add(String.Format(@"                                                                      "));
            screen.Add(String.Format(@"  3) {0}{1}"                                                          , str3, Utilities.SpaceBuilder(str3, 0, 65)));
            screen.Add(String.Format(@"                                                                      "));
            /*========================================================*/

            return screen;
        }
    }
}
