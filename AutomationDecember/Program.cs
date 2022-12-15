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
                TextEditor.PrintText("Select exercise to be done with text: \nDelete symbol from the text(1),\nDelete symbol from text in RegularExpressions(2),\nCharacter-by-character text(3),\nReverse case(4)");
                int variant = int.Parse(Console.ReadLine());
                TextEditor.PrintText("Enter your text:");
                string textToWrite = Console.ReadLine();
                if (variant == 1)
                {
                    TextEditor.PrintText("Enter symbol to delete from the text:");
                    string symbol = Console.ReadLine();
                    Console.Write("Text without deleted symbol \"{0}\" is:", symbol);
                    var newText = TextEditor.DeleteSymbol(textToWrite, symbol);
                    TextEditor.PrintText(newText);
                }
                else if (variant == 2)
                {
                    TextEditor.PrintText("Enter symbol to delete from the text using Regular expressions:");
                    string symbol = Console.ReadLine();
                    Console.Write("Text without deleted symbol \"{0}\" is:", symbol);
                    var newText = TextEditor.DeleteByRegularExpressions(textToWrite, symbol);
                    TextEditor.PrintText(newText);
                }
                else if (variant == 3)
                {
                    TextEditor.CharacterToCharacter(textToWrite);
                }
                else if (variant == 4)
                {
                    var newText = TextEditor.ReverseCase(textToWrite);
                    TextEditor.PrintText(newText);
                }
                TextEditor.PrintText("\nPress Enter to continue doing exercises or press the Escape (Esc) to quit!");
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}



