using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDecember
{
    internal class Print
    {
        public static void PrintText(string newText)
        {
            Console.WriteLine(newText);
        }

        public static void PrintTextInColumn(string enteredText)
        {
            var textLineInChar = enteredText.ToCharArray();
            for (var i = 0; i < textLineInChar.Length; i++)
            {
                Console.WriteLine(textLineInChar[i]);
            }
        }
    }
}
