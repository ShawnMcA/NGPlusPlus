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
            var ability1 = Player.Abilities[0].Name;
            var ability2 = Player.Abilities[1].Name;
            var ability3 = Player.Abilities.Count > 2 ? Player.Abilities[2].Name : "";

            /*========================================================*/
            screen.Add(String.Format(@"                                                                      "));
            screen.Add(String.Format(@"  1) {0}{1}"                                                          , ability1, Utilities.SpaceBuilder(ability1, 0, 65)));
            screen.Add(String.Format(@"                                                                      "));
            screen.Add(String.Format(@"  2) {0}{1}"                                                          , ability2, Utilities.SpaceBuilder(ability2, 0, 65)));
            screen.Add(String.Format(@"                                                                      "));
            screen.Add(String.Format(@"  3) {0}{1}"                                                          , ability3, Utilities.SpaceBuilder(ability3, 0, 65)));
            screen.Add(String.Format(@"                                                                      "));
            /*========================================================*/

            return screen;
        }
    }
}
