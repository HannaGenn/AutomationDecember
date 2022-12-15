using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace AutomationDecember
{
    public class TextEditor
    {
        public static void PrintText(string newText)
        {
            Console.WriteLine(newText);
        }
        public static string DeleteSymbol(string enteredText, string symbol)
        {
            char[] textToDisplayInChar = enteredText.ToCharArray();
            char[] result = new char[textToDisplayInChar.Length];
            var j = 0;
            var charSymbol = char.Parse(symbol);
            for (int i = 0; i < textToDisplayInChar.Length; i++)
            {
                if ((textToDisplayInChar[i] != charSymbol) && (char.ToUpper(textToDisplayInChar[i]) != char.ToUpper(charSymbol)))
                {
                    result[j] = textToDisplayInChar[i];
                    j++;
                }
            }
            return new string(result);
        }
        public static string DeleteByRegularExpressions(string enteredText, string symbol)
        {
            string spaceElement = "";
            Regex regexCase = new Regex($"[{symbol}]", RegexOptions.IgnoreCase);
            string result = regexCase.Replace(enteredText, spaceElement);
            return result;
        }
        public static void CharacterToCharacter(string enteredText)
        {
            char[] textLineInChar = enteredText.ToCharArray();
            for (int i = 0; i < textLineInChar.Length; i++)
            {
                Console.WriteLine(textLineInChar[i]);
            }
        }
        public static string ReverseCase(string enteredText)
        {
            char[] writeTextInChar = enteredText.ToCharArray();
            char[] reversedTextInChar = new char[writeTextInChar.Length];
            for (int i = 0; i < writeTextInChar.Length; i++)
            {
                if (writeTextInChar[i] == char.ToLower(writeTextInChar[i]))
                {
                    reversedTextInChar[i] = char.ToUpper(writeTextInChar[i]);
                }
                else if (writeTextInChar[i] == char.ToUpper(writeTextInChar[i]))
                {
                    reversedTextInChar[i] = char.ToLower(writeTextInChar[i]);
                }

            }
            return new string(reversedTextInChar);

        }

        /*        public static string ReverseCase(string enteredText)
                {
                    char[] writeTextInChar = enteredText.ToCharArray();
                    char[] reversedTextInChar = new char[writeTextInChar.Length];
                    int indexOfFirstElement = Array.IndexOf(writeTextInChar, writeTextInChar[0]);

                    for (int i = 0; i < writeTextInChar.Length; i++)
                    {
                        char elementFromInitialMassive = writeTextInChar[indexOfFirstElement];
                        if (elementFromInitialMassive == char.ToLower(elementFromInitialMassive))
                        {
                            reversedTextInChar[indexOfFirstElement] = char.ToUpper(writeTextInChar[indexOfFirstElement]);
                            indexOfFirstElement++;
                        }
                        else if (elementFromInitialMassive == char.ToUpper(elementFromInitialMassive))
                        {
                            reversedTextInChar[indexOfFirstElement] = char.ToLower(writeTextInChar[indexOfFirstElement]);
                            indexOfFirstElement++;
                        }
                    }
                    return new string(reversedTextInChar);

                }*/
    }

}
