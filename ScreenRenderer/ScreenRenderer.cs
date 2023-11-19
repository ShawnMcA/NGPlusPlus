using RPGGame.GameSettingsNamespace;
using RPGGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame.ScreenRendererNamespace
{
    public static class ScreenRenderer
    {
        private static void RenderScreen(List<string> screenRows)
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

        private static void DisplayError(string err) 
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(err);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
