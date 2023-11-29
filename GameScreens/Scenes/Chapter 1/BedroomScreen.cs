using NGPlusPlus.Interfaces;

namespace NGPlusPlus.GameScreensNamespace
{
    internal class BedroomScreen : IGameScreen
    {
        public int AnimationSpeed => 300;
        public List<List<string>> AnimationPackage()
        {
            var package = new List<List<string>>();

            package.Add(Screen1());
            package.Add(Screen2());
            package.Add(Screen3());
            package.Add(Screen4());

            return package;
        }

        public List<string> Screen1()
        {
            var screen = new List<string>();

            /*======================================================================================================================================================*/
            screen.Add(string.Format(@"           |                              ||               ||              ||                                       "));
            screen.Add(string.Format(@"           |                              ||===============||==============||                                       "));
            screen.Add(string.Format(@"           |                              ||               ||              ||                                       "));
            screen.Add(string.Format(@"           |                              ||               ||              ||                                       "));
            screen.Add(string.Format(@"           |                              ||               ||              ||                                       "));
            screen.Add(string.Format(@"           |                              ||               ||              ||                                       "));
            screen.Add(string.Format(@"           |                              ||               ||              ||                                    __ "));
            screen.Add(string.Format(@"           |                              /=================================\                                    |\\"));
            screen.Add(string.Format(@"           |                              '---------------------------------'                                    | \"));
            screen.Add(string.Format(@"           |                                                                                                     |  "));
            screen.Add(string.Format(@"           |                                                                                                     |  "));
            screen.Add(string.Format(@"           |                                                                                              _______|  "));
            screen.Add(string.Format(@"           |                      _  .___________________________________________________________________(\      \  "));
            screen.Add(string.Format(@"           |                      |\_|\                                                               \   \\      \ "));
            screen.Add(string.Format(@"           |______________________| \| \                        _____                                  \   \\      \"));
            screen.Add(string.Format(@"          /                       |  \  \                    _'-------'___                              \   \\______"));
            screen.Add(string.Format(@"         /                        |   \  \                  (_____________)~~~                           \   (\     "));
            screen.Add(string.Format(@"        /                         ||\  \  \                   '(________)'                                \   \\    "));
            screen.Add(string.Format(@"       /                          || \  \  \                                                               \   \\ __"));
            screen.Add(string.Format(@"      /                           []  \  \  \                                                               \   \(__"));
            screen.Add(string.Format(@"     /                                 \  \  \_______________________________________________________________\______"));
            screen.Add(string.Format(@"    /                                   \  \ |                                                                      "));
            screen.Add(string.Format(@"   /                                     \  \_______________________________________________________________________"));
            screen.Add(string.Format(@"  /                                       \ |                                                                       "));
            screen.Add(string.Format(@" /                                         || ______________________________________________________________________"));
            screen.Add(string.Format(@"/                                          || |                                                                     "));
            /*======================================================================================================================================================*/

            return screen;
        }

        public List<string> Screen2()
        {
            var screen = new List<string>();

            /*======================================================================================================================================================*/
            screen.Add(string.Format(@"           |                              ||               ||              ||                                       "));
            screen.Add(string.Format(@"           |                              ||===============||==============||                                       "));
            screen.Add(string.Format(@"           |                              ||               ||              ||                                       "));
            screen.Add(string.Format(@"           |                              ||               ||              ||                                       "));
            screen.Add(string.Format(@"           |                              ||               ||              ||                                       "));
            screen.Add(string.Format(@"           |                              ||               ||              ||                                       "));
            screen.Add(string.Format(@"           |                              ||               ||              ||                                    __ "));
            screen.Add(string.Format(@"           |                              /=================================\                                    |\\"));
            screen.Add(string.Format(@"           |                              '---------------------------------'                                    | \"));
            screen.Add(string.Format(@"           |                                                                                                     |  "));
            screen.Add(string.Format(@"           |                                                                                                     |  "));
            screen.Add(string.Format(@"           |                                                                                              _______|  "));
            screen.Add(string.Format(@"           |                      _  .___________________________________________________________________(\      \  "));
            screen.Add(string.Format(@"           |                      |\_|\                                                               \   \\      \ "));
            screen.Add(string.Format(@"           |______________________| \| \                        _____                                  \   \\      \"));
            screen.Add(string.Format(@"          /                       |  \  \                    _'-------'___                              \   \\______"));
            screen.Add(string.Format(@"         /                        |   \  \                 (_____________)~                              \   (\     "));
            screen.Add(string.Format(@"        /                         ||\  \  \                   '(________)'                                \   \\    "));
            screen.Add(string.Format(@"       /                          || \  \  \                                                               \   \\ __"));
            screen.Add(string.Format(@"      /                           []  \  \  \                                                               \   \(__"));
            screen.Add(string.Format(@"     /                                 \  \  \_______________________________________________________________\______"));
            screen.Add(string.Format(@"    /                                   \  \ |                                                                      "));
            screen.Add(string.Format(@"   /                                     \  \_______________________________________________________________________"));
            screen.Add(string.Format(@"  /                                       \ |                                                                       "));
            screen.Add(string.Format(@" /                                         || ______________________________________________________________________"));
            screen.Add(string.Format(@"/                                          || |                                                                     "));
            /*======================================================================================================================================================*/

            return screen;
        }

        public List<string> Screen3()
        {
            var screen = new List<string>();

            /*======================================================================================================================================================*/
            screen.Add(string.Format(@"           |                              ||               ||              ||                                       "));
            screen.Add(string.Format(@"           |                              ||===============||==============||                                       "));
            screen.Add(string.Format(@"           |                              ||               ||              ||                                       "));
            screen.Add(string.Format(@"           |                              ||               ||              ||                                       "));
            screen.Add(string.Format(@"           |                              ||               ||              ||                                       "));
            screen.Add(string.Format(@"           |                              ||               ||              ||                                       "));
            screen.Add(string.Format(@"           |                              ||               ||              ||                                    __ "));
            screen.Add(string.Format(@"           |                              /=================================\                                    |\\"));
            screen.Add(string.Format(@"           |                              '---------------------------------'                                    | \"));
            screen.Add(string.Format(@"           |                                                                                                     |  "));
            screen.Add(string.Format(@"           |                                                                                                     |  "));
            screen.Add(string.Format(@"           |                                                                                              _______|  "));
            screen.Add(string.Format(@"           |                      _  .___________________________________________________________________(\      \  "));
            screen.Add(string.Format(@"           |                      |\_|\                                                               \   \\      \ "));
            screen.Add(string.Format(@"           |______________________| \| \                        _____                                  \   \\      \"));
            screen.Add(string.Format(@"          /                       |  \  \                    _'-------'___                              \   \\______"));
            screen.Add(string.Format(@"         /                        |   \  \                  (_____________)                              \   (\     "));
            screen.Add(string.Format(@"        /                         ||\  \  \                   '(________)'                                \   \\    "));
            screen.Add(string.Format(@"       /                          || \  \  \                                                               \   \\ __"));
            screen.Add(string.Format(@"      /                           []  \  \  \                                                               \   \(__"));
            screen.Add(string.Format(@"     /                                 \  \  \_______________________________________________________________\______"));
            screen.Add(string.Format(@"    /                                   \  \ |                                                                      "));
            screen.Add(string.Format(@"   /                                     \  \_______________________________________________________________________"));
            screen.Add(string.Format(@"  /                                       \ |                                                                       "));
            screen.Add(string.Format(@" /                                         || ______________________________________________________________________"));
            screen.Add(string.Format(@"/                                          || |                                                                     "));
            /*======================================================================================================================================================*/

            return screen;
        }

        public List<string> Screen4()
        {
            var screen = new List<string>();

            /*======================================================================================================================================================*/
            screen.Add(string.Format(@"           |                              ||               ||              ||                                       "));
            screen.Add(string.Format(@"           |                              ||===============||==============||                                       "));
            screen.Add(string.Format(@"           |                              ||               ||              ||                                       "));
            screen.Add(string.Format(@"           |                              ||               ||              ||                                       "));
            screen.Add(string.Format(@"           |                              ||               ||              ||                                       "));
            screen.Add(string.Format(@"           |                              ||               ||              ||                                       "));
            screen.Add(string.Format(@"           |                              ||               ||              ||                                    __ "));
            screen.Add(string.Format(@"           |                              /=================================\                                    |\\"));
            screen.Add(string.Format(@"           |                              '---------------------------------'                                    | \"));
            screen.Add(string.Format(@"           |                                                                                                     |  "));
            screen.Add(string.Format(@"           |                                                                                                     |  "));
            screen.Add(string.Format(@"           |                                                                                              _______|  "));
            screen.Add(string.Format(@"           |                      _  .___________________________________________________________________(\      \  "));
            screen.Add(string.Format(@"           |                      |\_|\                                                               \   \\      \ "));
            screen.Add(string.Format(@"           |______________________| \| \                       _____                                   \   \\      \"));
            screen.Add(string.Format(@"          /                       |  \  \                   _'-------'___                               \   \\______"));
            screen.Add(string.Format(@"         /                        |   \  \                 (_____________)                               \   (\     "));
            screen.Add(string.Format(@"        /                         ||\  \  \                   '(________)'                                \   \\    "));
            screen.Add(string.Format(@"       /                          || \  \  \                                                               \   \\ __"));
            screen.Add(string.Format(@"      /                           []  \  \  \                                                               \   \(__"));
            screen.Add(string.Format(@"     /                                 \  \  \_______________________________________________________________\______"));
            screen.Add(string.Format(@"    /                                   \  \ |                                                                      "));
            screen.Add(string.Format(@"   /                                     \  \_______________________________________________________________________"));
            screen.Add(string.Format(@"  /                                       \ |                                                                       "));
            screen.Add(string.Format(@" /                                         || ______________________________________________________________________"));
            screen.Add(string.Format(@"/                                          || |                                                                     "));
            /*======================================================================================================================================================*/

            return screen;
        }
    }
}
