namespace Day_10_BinaryNumbers;

internal class Solution
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        string binary = ConvertToBinary(n);
        int result = MaximumConsecutiveCharCount(binary, '1');
        Console.WriteLine(result);
        //int resultWithLinq = MaximumConsecutiveOnesCount(binary);
        //Console.WriteLine(resultWithLinq);
    }

    public static string ConvertToBinary(int number)
        => Convert.ToString(number, toBase: 2);

    public static int MaximumConsecutiveCharCount(string word, char search)
    {
        // 101      -> 1
        // 1111     -> 4
        // 01010    -> 1
        // 10110    -> 2
        // 1110011  -> 3
        // 11111001 -> 5
        // 11001111 -> 4
        int maxConsecutiveCount = 0;
        int currentCount = 1;

        for (int i = 0; i < word.Length; i++)
        {
            if (i < word.Length - 1
                && word[i] == search
                && word[i] == word[i + 1])
            {
                currentCount++;
            }
            else
            {
                if (currentCount > maxConsecutiveCount)
                {
                    maxConsecutiveCount = currentCount;
                }
                currentCount = 1;
            }
        }

        return maxConsecutiveCount;
    }

    public static int MaximumConsecutiveOnesCount(string word)
    {
        string[] strings = word.Split('0');
        return strings.Max().Length;
    }
}
