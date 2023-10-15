namespace Day_29_BitwiseAnd;

class Result
{
    public static int bitwiseAnd(int N, int K) => (K - 1 | K) <= N ? K - 1 : K - 2;
}

internal class Solution
{
    static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
            int count = Convert.ToInt32(firstMultipleInput[0]);
            int lim = Convert.ToInt32(firstMultipleInput[1]);
            int res = Result.bitwiseAnd(count, lim);
            Console.WriteLine(res);
        }
    }
}
