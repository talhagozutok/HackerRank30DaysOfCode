namespace Day_11_TwoDimensionalArrays;

internal class Solution
{
    static void Main(string[] args)
    {
        List<List<int>> arr = new();

        for (int i = 0; i < 6; i++)
        {
            arr.Add(
                Console.ReadLine().TrimEnd().Split(' ')
                .ToList()
                .Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        List<List<int>> hourglassList = GetHourglasses(arr);
        int maxSum = GetMaximumHourglass(hourglassList);
        Console.WriteLine(maxSum);
    }

    public static List<List<int>> GetHourglasses(List<List<int>> arr)
    {
        List<List<int>> hourglassList = new();

        for (int i = 0; i < 4; i++)
        {
            List<List<int>> currentHourglass = new();
            for (int j = 0; j < 4; j++)
            {
                currentHourglass.Add(new List<int>()
                {
                    arr[i][j], arr[i][j+1], arr[i][j+2],
                    arr[i+1][j+1],
                    arr[i+2][j], arr[i+2][j+1],arr[i+2][j+2]
                });
            }
            hourglassList.AddRange(currentHourglass);
        }

        return hourglassList;
    }

    public static int GetMaximumHourglass(List<List<int>> hourglassList)
    {
        var result = hourglassList
            .Select(list =>
                list.Aggregate((number, next) => number + next));

        return result.Max();
    }
}
