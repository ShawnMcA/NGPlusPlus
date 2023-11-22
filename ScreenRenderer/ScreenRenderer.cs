using NGPlusPlus.GameSettingsNamespace;
using NGPlusPlus.Interfaces;

namespace NGPlusPlus.ScreenRendererNamespace
{
    public static class ScreenRenderer
    {
        public static void RenderScreen(List<string> screenRows)
        {
            if(screenRows.Count > GameSettings.MAX_SCREEN_ROWS)
            {
                DisplayError("ERROR: Screen Rows array too large for screen");
                return;
            }

            Console.SetCursorPosition(0, 0);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;

            var emptyRows = GameSettings.DISPLAY_HEIGHT - 4 - screenRows.Count;
            var emptyRowsTop = Math.Floor((float)emptyRows / 2);
            var emptyRowsBottom = Math.Ceiling((float)emptyRows / 2);
            var screenRowCurrentIndex = 0;

            for (var i = 1; i <= GameSettings.DISPLAY_HEIGHT; i++)
            {
                if (i <= 2 || i > GameSettings.DISPLAY_HEIGHT - 2)
                {
                    Console.WriteLine(new string('*', GameSettings.DISPLAY_WIDTH));
                } 
                
                else 
                {
                    Console.Write("**");
                    Console.ForegroundColor = ConsoleColor.White;

                    if (emptyRowsTop > 0)
                    {
                        Console.Write(new string(' ', GameSettings.MAX_SCREEN_ROW_CHARS));

                        emptyRowsTop--;
                    }

                    else if (screenRows.Count > 0 && screenRowCurrentIndex != screenRows.Count)
                    {
                        if (screenRows[screenRowCurrentIndex].Length > GameSettings.MAX_SCREEN_ROW_CHARS)
                        {
                            DisplayError("ERROR: Screen Row length too large for screen");
                            break;
                        }

                        var emptyChars = GameSettings.MAX_SCREEN_ROW_CHARS - screenRows[screenRowCurrentIndex].Length;
                        var emptyCharsLeft = Math.Floor((float)emptyChars / 2);
                        var emptyCharsRight = Math.Ceiling((float)emptyChars / 2);

                        Console.Write(new string(' ', (int)emptyCharsLeft));

                        Console.Write(screenRows[screenRowCurrentIndex]);

                        Console.Write(new string(' ', (int)emptyCharsRight));

                        screenRowCurrentIndex++;
                    }

                    else if (emptyRowsBottom > 0)
                    {
                        Console.Write(new string(' ', GameSettings.MAX_SCREEN_ROW_CHARS));

                        emptyRowsBottom--;
                    }

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("**\r\n");

                }
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void RenderSection(List<string> sectionRows, 
            int startPosLeft, 
            int startPosTop,
            int sectionWidth,
            int sectionHeight)
        {
            Console.ForegroundColor = ConsoleColor.White;

            var emptyRows = sectionHeight - sectionRows.Count;
            var emptyRowsTop = Math.Floor((float)emptyRows / 2);
            var emptyRowsBottom = Math.Ceiling((float)emptyRows / 2);
            var sectionRowCurrentIndex = 0;

            for (var i = 0; i < sectionHeight; i++)
            {
                Console.SetCursorPosition(startPosLeft, startPosTop + i);

                if (emptyRowsTop > 0)
                {
                    Console.Write(new string(' ', sectionWidth));
                }

                else if (sectionRows.Count > 0 && sectionRowCurrentIndex != sectionRows.Count)
                {
                    if (sectionRows[sectionRowCurrentIndex].Length > sectionWidth)
                    {
                        DisplayError("ERROR: Section Row length too large for section");
                        break;
                    }

                    var emptyChars = sectionWidth - sectionRows[sectionRowCurrentIndex].Length;
                    var emptyCharsLeft = Math.Floor((float)emptyChars / 2);
                    var emptyCharsRight = Math.Ceiling((float)emptyChars / 2);

                    Console.Write(new string(' ', (int)emptyCharsLeft));

                    Console.Write(sectionRows[sectionRowCurrentIndex]);

                    Console.Write(new string(' ', (int)emptyCharsRight));

                    sectionRowCurrentIndex++;
                }

                else if (emptyRowsBottom > 0)
                {
                    Console.Write(new string(' ', GameSettings.MAX_SCREEN_ROW_CHARS));

                    emptyRowsBottom--;
                }

                Console.Write("\r\n");
            }
        }

        public static void RenderAnimation(IGameScreen screen) 
        {
            var gameScreens = screen.AnimationPackage();

            foreach (var gameScreen in gameScreens)
            {
                RenderScreen(gameScreen);

                if (gameScreens.Count > 1)
                    Thread.Sleep(screen.AnimationSpeed);
            }
        }

        public static void RenderAnimation(IGameScreen screen,
            int startPosLeft,
            int startPosTop,
            int sectionWidth,
            int sectionHeight)
        {
            var gameScreens = screen.AnimationPackage();

            foreach (var gameScreen in gameScreens)
            {
                RenderSection(gameScreen, startPosLeft, startPosTop, sectionWidth, sectionHeight);

                if (gameScreens.Count > 1)
                    Thread.Sleep(screen.AnimationSpeed);
            }
        }

        private static void DisplayError(string err) 
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(err);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
