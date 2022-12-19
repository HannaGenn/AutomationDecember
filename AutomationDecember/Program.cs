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
                Print.PrintText("Select exercise to be done with text: \nDelete symbol from text(1),\nDelete symbol from text in RegularExpressions(2)," +
                "\nDelete symbol using dynamic array(3),\nCharacter-by-character text(4),\nReverse case(5)");
                var variant = int.Parse(Console.ReadLine());
                Print.PrintText("Enter your text:");
                var textToWrite = Console.ReadLine();
                switch (variant)
                {
                    case 1:
                        var symbolToRemove = StringHelper.GetSymbolForDelete();
                        var newText = StringHelper.DeleteSymbol(textToWrite,symbolToRemove);
                        Print.PrintText(newText);
                        break;
                    case 2:
                        var symbolToCut = StringHelper.GetSymbolForDelete();
                        var newTextLine = StringHelper.DeleteByRegularExpressions(textToWrite,symbolToCut);
                        Print.PrintText(newTextLine);
                        break;
                    case 3:
                        var symbolToDelete = StringHelper.GetSymbolForDelete();
                        var newTextInLine = StringHelper.DeleteSymbolDynamic(textToWrite, symbolToDelete);
                        Print.PrintText(newTextInLine);
                        break;
                    case 4:
                        Print.PrintTextInColumn(textToWrite);
                        break;
                    case 5:
                        var newTextToPrint = StringHelper.ReverseCase(textToWrite);
                        Print.PrintText(newTextToPrint);
                        break;
                }
                Print.PrintText("\nPress Enter to continue doing exercises or press the Escape (Esc) to quit!");
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}



