using System;

namespace allExercises
{
    internal class Program
    {
        static void DeleteSymbol(string enteredText)
        {
            Console.WriteLine("Enter symbol to delete from the text:");
            string symbol = Console.ReadLine();
            Console.Write("Text without deleted symbol \"{0}\" is:", symbol);
            char[] textToDisplayInChar = enteredText.ToCharArray();
            for (int i = 0; i < textToDisplayInChar.Length; i++)
            {
                string elementFromMassiveToCompare = char.ToString(textToDisplayInChar[i]);
                bool firstComparison = (elementFromMassiveToCompare == symbol);
                bool secondComparison = (elementFromMassiveToCompare.ToUpper() == symbol.ToUpper());

                if (!firstComparison && !secondComparison)
                {
                    Console.Write(textToDisplayInChar[i]);
                }
            }

        }

        static void CharacterToCharacter(string enteredText)
        {
            char[] textLineInChar = enteredText.ToCharArray();
            for (int i = 0; i < textLineInChar.Length; i++)
            {
                Console.WriteLine(textLineInChar[i]);
            }
        }

        static void Reverse(string enteredText)
        {
            char[] writeTextInChar = enteredText.ToCharArray();
            char[] reversedTextInChar = new char[writeTextInChar.Length];
            int reversedArraySymbolIndex = 0;
            for (int i = writeTextInChar.Length - 1; i >= 0; i--)
            {
                reversedTextInChar[reversedArraySymbolIndex] = writeTextInChar[i];
                Console.Write(reversedTextInChar[reversedArraySymbolIndex]);
            }
        }


        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Select exercise to be done with text: Delete symbol from the text(1),character-by-character text(2), reverse text(3)");
                int variant = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your text:");
                string textToWrite = Console.ReadLine();
                while (true)
                {
                    if (variant == 1)
                    {
                        DeleteSymbol(textToWrite);
                    }
                    else if (variant == 2)
                    {
                        CharacterToCharacter(textToWrite);
                    }
                    else if (variant == 3)
                    {
                        Reverse(textToWrite);
                    }
                    Console.Write("\n");
                    Console.Write("Press Enter to continue doing exercises!");
                    Console.ReadLine();
                    break;


                }
            }

        }
    }
}