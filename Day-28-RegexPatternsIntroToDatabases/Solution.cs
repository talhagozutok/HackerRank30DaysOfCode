using System.Text.RegularExpressions;

namespace Day_28_RegexPatternsIntroToDatabases;

internal class Solution
{
    static bool IsValidGmail(string mail)
    {
        const string GmailRegex = "@gmail\\.com";
        return Regex.IsMatch(mail, GmailRegex);
    }

    static void Main(string[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine().Trim());
        var namesThatHasGmailAddress = new List<string>();

        for (int NItr = 0; NItr < N; NItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
            string firstName = firstMultipleInput[0];
            string emailID = firstMultipleInput[1];

            if (IsValidGmail(emailID))
            {
                namesThatHasGmailAddress.Add(firstName);
            }
        }

        namesThatHasGmailAddress.Sort();
        namesThatHasGmailAddress.ForEach(Console.WriteLine);
    }
}
