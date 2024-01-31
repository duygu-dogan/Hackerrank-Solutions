namespace _08_day_dictionaries_maps;

class Solution
{
    static void Main(String[] args)
    {
        // Given n names and phone numbers, assemble a phone book that maps friends' names to their respective phone numbers. You will then be given an unknown number of names to query your phone book for. For each name  queried, print the associated entry from your phone book on a new line in the form name=phoneNumber; if an entry for name is not found, print Not found instead.

        // Note: Your phone book should be a Dictionary/Map/HashMap data structure.

        int n = Convert.ToInt32(Console.ReadLine());
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();
        string name;
        List<string> result = new List<string>();

        for (int i = 0; i < n; i++)
        {
            List<string> list = Console.ReadLine().TrimEnd().Split(' ').ToList();
            phoneBook.Add(list[0], list[1]);
        }
        while ((name = Console.ReadLine()) != null)
        {
            if (phoneBook.ContainsKey(name))
            {
                result.Add(name + "=" + phoneBook[name]);
            }
            else
            {
                result.Add("Not found");
            }
        }

        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }
}
