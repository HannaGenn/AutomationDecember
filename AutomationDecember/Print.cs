using System;

namespace AutomationDecember
{
    public class Print
    {
        public static void Text(string result, string message = null)
        {
            Console.WriteLine(message + result);
        }

        public static void TextToColumn(string enteredText)
        {
            var textLineInChar = enteredText.ToCharArray();
            for (var i = 0; i < textLineInChar.Length; i++)
            {
                Console.WriteLine(textLineInChar[i]);
            }
        }
    }
}
