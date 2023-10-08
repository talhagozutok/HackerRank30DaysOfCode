namespace Day_16_Exceptions;

internal class Solution
{
    static void Main(string[] args)
    {
        string S = Console.ReadLine();

        try
        {
            Console.WriteLine(int.Parse(S));
        }
        catch
        {
            Console.WriteLine("Bad String");
        }
    }
}
