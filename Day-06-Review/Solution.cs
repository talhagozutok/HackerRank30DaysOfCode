namespace Day_06_Review;

internal class Solution
{
    static void Main(string[] args)
    {
        int numberOfSamples = int.Parse(Console.ReadLine());
        List<string> inputs = GetStringInputs(numberOfSamples);

        for (int i = 0; i < inputs.Count; i++)
        {
            string result = GetEvenOddCharacters(inputs[i]);
            Console.WriteLine(result);
        }
    }

    static List<string> GetStringInputs(int n)
    {
        List<string> inputStrings = new List<string>();

        for (int i = 0; i < n; i++)
        {
            inputStrings.Add(Console.ReadLine());
        }

        return inputStrings;
    }

    static string GetEvenOddCharacters(string input)
    {
        string result = string.Empty;

        for (int j = 0; j < input.Length; j = j + 2)
        {
            result += input[j];
        }
        result += " ";
        for (int j = 1; j < input.Length; j = j + 2)
        {
            result += input[j];
        }

        return result;
    }
}
