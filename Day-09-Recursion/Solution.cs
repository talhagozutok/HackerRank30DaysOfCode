namespace Day_09_Recursion;
class Result
{
    public static int Factorial(int n)
    {
        if (n <= 1)
        {
            return 1;
        }

        return n * Factorial(n - 1);
    }
}

internal class Solution
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        int result = Result.Factorial(n);

        Console.WriteLine(result);
    }
}
