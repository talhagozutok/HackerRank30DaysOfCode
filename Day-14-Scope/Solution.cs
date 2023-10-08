namespace Day_14_Scope;

class Difference
{
    private int[] elements;
    public int maximumDifference;

    // Add your code here
    public Difference(int[] arr)
    {
        elements = arr;
    }

    public void computeDifference()
    {
        int max = elements.Max();
        int min = elements.Min();

        maximumDifference = Math.Abs(max - min);
    }

} // End of Difference Class

internal class Solution
{
    static void Main(string[] args)
    {
        Convert.ToInt32(Console.ReadLine());

        int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

        Difference d = new Difference(a);

        d.computeDifference();

        Console.Write(d.maximumDifference);
    }
}
