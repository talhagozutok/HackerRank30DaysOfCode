namespace Day_20_Sorting;

internal class Solution
{

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> numberList = Console.ReadLine()
            .TrimEnd().Split(' ').ToList()
            .Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        // Write your code here
        int numberOfSwaps = 0;
        int listCount = numberList.Count;

        for (int i = 0; i < listCount; i++)
        {
            for (int j = 0; j < listCount - 1; j++)
            {
                // Swap adjacent elements if they are in decreasing order
                if (numberList[j] > numberList[j + 1])
                {
                    int temp = numberList[j];
                    numberList[j] = numberList[j + 1];
                    numberList[j + 1] = temp;
                    numberOfSwaps++;
                }
            }

            // If no elements were swapped during numberList traversal, array is sorted
            if (numberOfSwaps == 0)
            {
                break;
            }
        }

        Console.WriteLine($"Array is sorted in {numberOfSwaps} swaps.");
        Console.WriteLine($"First Element: {numberList[0]}");
        Console.WriteLine($"Last Element: {numberList[n - 1]}");
    }
}
