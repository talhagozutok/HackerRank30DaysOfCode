namespace Day_26_NestedLogic;

internal class Solution
{
    public static DateOnly GetDate(int year, int month, int day)
    {
        return new DateOnly(year, month, day);
    }

    public static int CalculateFee(DateOnly dateReturn, DateOnly dateDue)
    {
        if (dateReturn <= dateDue) return 0;

        if (dateReturn.Month == dateDue.Month &&
            dateReturn.Year == dateDue.Year)
            return 15 * (dateReturn.Day - dateDue.Day);

        if (dateReturn.Year == dateDue.Year)
            return 500 * (dateReturn.Month - dateDue.Month);

        return 10000;
    }

    static void Main(string[] args)
    {
        int[] dateReturnArr = Console.ReadLine().Trim().Split(' ')
            .Select(x => Convert.ToInt32(x)).ToArray();
        DateOnly dateReturn = GetDate(
            dateReturnArr[2],
            dateReturnArr[1],
            dateReturnArr[0]);

        int[] dateDueArr = Console.ReadLine().Trim().Split(' ')
            .Select(x => Convert.ToInt32(x)).ToArray();
        DateOnly dateDue = GetDate(
            dateDueArr[2],
            dateDueArr[1],
            dateDueArr[0]);

        int fee = CalculateFee(dateReturn, dateDue);
        Console.WriteLine(fee);
    }
}
