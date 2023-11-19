using System;
using System.Collections;
using System.Collections.Generic;

namespace RPGGame.Core
{
    public static class Utilities
    {
        public static void WaitForEnterPress() 
        {
            WaitForKeyPress(ConsoleKey.Enter);
        }


        private static void WaitForKeyPress(ConsoleKey key) 
        {
            Console.SetCursorPosition(2, Console.CursorTop);

            while (Console.ReadKey(true).Key != key) {
                
            }
        }

        public static string SpaceBuilder(
            int val1, 
            int val2, 
            int alreadyFilled, 
            int spacesToFill)
        {
            var str1 = val1.ToString();
            var str2 = val2.ToString();

            return new string(' ', spacesToFill - alreadyFilled - str1.Length - str2.Length);
        }

        public static string SpaceBuilder(
            int val1,
            string val2,
            int alreadyFilled,
            int spacesToFill)
        {
            var str1 = val1.ToString();

            return new string(' ', spacesToFill - alreadyFilled - str1.Length - val2.Length);
        }

        public static string SpaceBuilder(
            string val2,
            int alreadyFilled,
            int spacesToFill)
        {
            return new string(' ', spacesToFill - alreadyFilled - val2.Length);
        }
    }
}

