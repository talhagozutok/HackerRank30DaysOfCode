namespace Day_25_RunningTimeAndComplexity;

internal class Solution
{
    static bool IsPrime(long number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        var boundary = (int)Math.Floor(Math.Sqrt(number));

        for (int i = 3; i <= boundary; i += 2)
            if (number % i == 0)
                return false;

        return true;
    }

    static void Main(string[] args)
    {
        int numberOfInput = Convert.ToInt32(Console.ReadLine().Trim());

        List<long> inputList = new();
        for (int i = 0; i < numberOfInput; i++)
        {
            inputList.Add(Convert.ToInt32(Console.ReadLine()));
        }

        foreach (long i in inputList)
        {
            if (IsPrime(i))
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not prime");
            }
        }
    }
}
