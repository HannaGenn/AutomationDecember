using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace NetFundamentals
{
    public class StringHelper
    {
        public static string GetSymbolForDelete()
        {
            Print.Text("Enter symbol to delete from the text:");
            var symbol = Console.ReadLine();
            Console.Write("Text without deleted symbol \"{0}\" is:", symbol);

            return symbol;
        }

        public static string DeleteSymbol(string enteredText, string symbol)
        {
            var textToDisplayInChar = enteredText.ToCharArray();
            var newCharWithoutSymbol = new char[textToDisplayInChar.Length];
            var indexOfCharWithoutSymbol = 0;
            var charSymbol = char.Parse(symbol);
            for (var i = 0; i < textToDisplayInChar.Length; i++)
            {
                if ((textToDisplayInChar[i] != charSymbol) && (char.ToUpper(textToDisplayInChar[i]) != char.ToUpper(charSymbol)))
                {
                    newCharWithoutSymbol[indexOfCharWithoutSymbol] = textToDisplayInChar[i];
                    indexOfCharWithoutSymbol++;
                }
            }

            return new string(newCharWithoutSymbol);
        }

        public static string DeleteByRegularExpressions(string enteredText, string symbol)
        {
            var regexCase = new Regex($"[{symbol}]", RegexOptions.IgnoreCase);
            var result = regexCase.Replace(enteredText, string.Empty);

            return result;
        }

        public static string DeleteSymbolDynamic(string enteredText, string symbol)
        {
            var textToDisplayInChar = enteredText.ToCharArray().ToList();
            List<char> dynamicArrayChar = new List<char>();
            for (var i = 0; i < textToDisplayInChar.Count; i++)
            {
                if (textToDisplayInChar[i].ToString().ToUpper() != symbol.ToUpper())
                {
                    dynamicArrayChar.Add(textToDisplayInChar[i]);
                }
            }

            return new string(dynamicArrayChar.ToArray());
        }

        public static string ReverseCase(string enteredText)
        {
            var writeTextInChar = enteredText.ToCharArray();
            var reversedTextInChar = new char[writeTextInChar.Length];
            for (var i = 0; i < writeTextInChar.Length; i++)
            {
                if (writeTextInChar[i] == char.ToLower(writeTextInChar[i]))
                {
                    reversedTextInChar[i] = char.ToUpper(writeTextInChar[i]);
                }
                else
                {
                    reversedTextInChar[i] = char.ToLower(writeTextInChar[i]);
                }
            }

            return new string(reversedTextInChar);

        }

        //one more method for reverse case

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
                        else
                        {
                            reversedTextInChar[indexOfFirstElement] = char.ToLower(writeTextInChar[indexOfFirstElement]);
                            indexOfFirstElement++;
                        }
                    }
                    return new string(reversedTextInChar);

                }*/
    }

}
