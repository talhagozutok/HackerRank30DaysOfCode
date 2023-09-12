namespace Day_01_DataTypes;

class Solution
{
    static void Main(string[] args)
    {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        // Declare second integer, double, and String variables.
        int userInt;
        double userDouble;
        string userString;

        // Read and save an integer, double, and String to your variables.
        userInt = int.Parse(Console.ReadLine());
        userDouble = double.Parse(Console.ReadLine());
        userString = Console.ReadLine();
        Console.Clear();

        // Print the sum of both integer variables on a new line.
        Console.WriteLine(i + userInt);

        // Print the sum of the double variables on a new line.
        Console.WriteLine($"{d + userDouble:0.0}");

        // Concatenate and print the String variables on a new line
        // The 's' variable above should be printed first.
        Console.WriteLine(s + userString);
    }
}
