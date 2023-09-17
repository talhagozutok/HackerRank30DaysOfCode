class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Console.WriteLine(GetReverseArray(arr));
    }

    public static string GetReverseArray(List<int> arr)
    {
        arr.Reverse();
        string result = string.Join(' ', arr);
        return result;
    }
}
