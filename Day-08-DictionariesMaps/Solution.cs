namespace Day_08_DictionariesMaps;

internal class Solution
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine().Trim());

        Dictionary<string, string> phoneBook = new();

        for (int i = 0; i < n; i++)
        {
            string[] phoneBookRecord = Console.ReadLine()
                .TrimEnd()
                .Split(' ');

            phoneBook.Add(
                phoneBookRecord[0],
                phoneBookRecord[1]);
        }

        string phoneOwnerInput = string.Empty;
        while ((phoneOwnerInput = Console.ReadLine()) != null)
        {
            ShowPhoneNumber(phoneBook, phoneOwnerInput);
        }
    }

    static string GetPhoneNumber(
        Dictionary<string, string> phoneBook,
        string phoneOwner)
    {
        phoneBook.TryGetValue(
            phoneOwner,
            out string? phoneNumber);

        return phoneNumber;
    }

    static void ShowPhoneNumber(
        Dictionary<string, string> phoneBook,
        string phoneOwner)
    {
        string phoneNumber = GetPhoneNumber(
                phoneBook,
                phoneOwner);

        if (phoneNumber is null)
        {
            Console.WriteLine("Not found");
        }
        else
        {
            Console.WriteLine($"{phoneOwner}={phoneNumber}");
        }
    }
}
