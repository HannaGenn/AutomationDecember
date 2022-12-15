using System;
using AutomationDecember;

namespace allExercises
{
    internal class Program
    {
        static void Main()
        {
            do
            {
                WorkWithText.PrintText("Select exercise to be done with text: \nDelete symbol from text(1),\nDelete symbol from text in RegularExpressions(2)," +
                "\nDelete symbol using dynamic array(3),\nCharacter-by-character text(4),\nReverse case(5)");
                var variant = int.Parse(Console.ReadLine());
                WorkWithText.PrintText("Enter your text:");
                var textToWrite = Console.ReadLine();
                if (variant == 1)
                {
                    var symbol = WorkWithText.GetSymbolForDelete();
                    var newText = WorkWithText.DeleteSymbol(textToWrite,symbol);
                    WorkWithText.PrintText(newText);
                }
                else if (variant == 2)
                {
                    var symbol = WorkWithText.GetSymbolForDelete();
                    var newText = WorkWithText.DeleteByRegularExpressions(textToWrite, symbol);
                    WorkWithText.PrintText(newText);
                }
                else if (variant == 3)
                {
                    var symbol = WorkWithText.GetSymbolForDelete();
                    var newText = WorkWithText.DeleteSymbolDynamic(textToWrite, symbol);
                    WorkWithText.PrintText(newText);
                }
                else if (variant == 4)
                {
                    WorkWithText.CharacterToCharacter(textToWrite);
                }
                else if (variant == 5)
                {
                    var newText = WorkWithText.ReverseCase(textToWrite);
                    WorkWithText.PrintText(newText);
                }
                WorkWithText.PrintText("\nPress Enter to continue doing exercises or press the Escape (Esc) to quit!");
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}



