using NGPlusPlus.Core;
using NGPlusPlus.Interfaces;
using NGPlusPlus.PlayerNameSpace;

namespace NGPlusPlus.GameScreensNamespace
{
    internal class AbilityMenuScreen : IGameScreen
    {
        private Player Player;
        public int AnimationSpeed => 300;
        public AbilityMenuScreen() 
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

            var str1 = $"1) {Player.Abilities[0].Name} ({Player.Abilities[0].ManaCost} MP)";
            var str2 = $"2) {Player.Abilities[1].Name} ({Player.Abilities[1].ManaCost} MP)";
            var str3 = Player.Abilities.Count < 3 ? "" : $"3) {Player.Abilities[2].Name} ({Player.Abilities[2].ManaCost} MP)";
            var str4 = Player.Abilities.Count < 4 ? "" : $"4) {Player.Abilities[3].Name} ({Player.Abilities[3].ManaCost} MP)";
            var str5 = Player.Abilities.Count < 5 ? "" : $"5) {Player.Abilities[4].Name} ({Player.Abilities[4].ManaCost} MP)";

            /*========================================================*/
            screen.Add(String.Format(@"                                                                      "));
            screen.Add(String.Format(@"  {0}{1}"                                                             , str1, Utilities.SpaceBuilder(str1, 0, 65)));
            screen.Add(String.Format(@"  {0}{1}"                                                             , str2, Utilities.SpaceBuilder(str2, 0, 65)));
            screen.Add(String.Format(@"  {0}{1}"                                                             , str3, Utilities.SpaceBuilder(str3, 0, 65)));
            screen.Add(String.Format(@"  {0}{1}"                                                             , str4, Utilities.SpaceBuilder(str4, 0, 65)));
            screen.Add(String.Format(@"  {0}{1}"                                                             , str5, Utilities.SpaceBuilder(str5, 0, 65)));
            screen.Add(String.Format(@"                                                                      "));
            /*========================================================*/

            return screen;
        }
    }
}
