using System;

namespace AutomationDecember
{
    public class ReturnNumbers
    {
        public static string GetNumberResults(string enteredNumbers)
        {
            var numbers = enteredNumbers.Split(new[] { " " },StringSplitOptions.RemoveEmptyEntries);
            var numbersToInt = Array.ConvertAll(numbers, s => int.Parse(s));
            var highestNumber = GetHighestNumber(numbersToInt);
            var lowestNumber = GetLowestNumber(numbersToInt);
            var highestAndLowestNumbers = highestNumber.ToString() +" "+lowestNumber.ToString();
            return highestAndLowestNumbers;
        }

        private static int GetLowestNumber(int[] numbersArray)
        {
            var resultLowestInt = numbersArray[0];
            for (var i = 0; i < numbersArray.Length - 1; i++)
                if (numbersArray[i + 1] < resultLowestInt)
                {
                    resultLowestInt = numbersArray[i + 1];
                }

            return resultLowestInt;
        }

        private static int GetHighestNumber(int[] numbersArray)
        {
            var resultHighestInt = numbersArray[0];
            for (var i = 0; i < numbersArray.Length - 1; i++)
                if (numbersArray[i + 1] > resultHighestInt)
                {
                    resultHighestInt = numbersArray[i + 1];
                }

            return resultHighestInt;
        }
    }
}
