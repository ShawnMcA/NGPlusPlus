using NGPlusPlus.GameSettingsNamespace;
using System;
using System.Collections;
using System.Collections.Generic;

namespace NGPlusPlus.Core
{
    public static class TextLogger
    {
        public static void WriteText(string text) 
        {

            Console.SetCursorPosition(2, Console.CursorTop);
            Console.WriteLine(text);
            Console.WriteLine();
            Console.SetCursorPosition(2, Console.CursorTop);
        }

        public static void ClearWriteText(string text)
        {
            ClearWindow();
            Console.SetCursorPosition(2, Console.CursorTop);
            Console.WriteLine(text);
            Console.WriteLine();
            Console.SetCursorPosition(2, Console.CursorTop);
        }

        public static void WriteTextAndWait(string text)
        {
            Console.SetCursorPosition(2, Console.CursorTop);
            Console.WriteLine(text);
            Console.WriteLine();
            Utilities.WaitForEnterPress();
        }

        public static void ClearWriteTextAndWait(string text) 
        {
            ClearWindow();
            Console.SetCursorPosition(2, Console.CursorTop);
            Console.WriteLine(text);
            Console.WriteLine();
            Utilities.WaitForEnterPress();
        }

        public static void ClearWindow()
        {
            for(var i = GameSettings.DISPLAY_HEIGHT + 2; i < GameSettings.WINDOW_HEIGHT; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write(new string(' ', Console.WindowWidth));
            }


            Console.SetCursorPosition(2, GameSettings.DISPLAY_HEIGHT + 2);
        }
    }
}

