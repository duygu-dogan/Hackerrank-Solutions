namespace _06_day_lets_review;

class Solution
{
    //     Task
    // Given a string, S, of length N that is indexed from 0 to N-1, print its even-indexed and odd-indexed characters as 2 space-separated strings on a single line (see the Sample below for more detail).

    // Note: 0 is considered to be an even index.
    static void Main(string[] args)
    {
        int T = Convert.ToInt32(Console.ReadLine());
        while (T <= 0 || T > 10)
        {
            Console.WriteLine("You entered a wrong number. Please enter the number of tests you would like to perform. It must be between 1 and 10.");
            T = Convert.ToInt32(Console.ReadLine());
        }
        List<string> wordList = new List<string>();

        for (int i = 0; i < T; i++)
        {
            wordList.Add(Console.ReadLine());
        }

        foreach (var item in wordList)
        {
            List<char> oddLetters = new List<char>();
            List<char> evenLetters = new List<char>();
            for (int i = 0; i < item.Length; i++)
            {
                if (i % 2 == 0)
                {
                    evenLetters.Add(item[i]);
                }
                else
                {
                    oddLetters.Add(item[i]);
                }
            }
            string evens = new string(evenLetters.ToArray());
            string odds = new string(oddLetters.ToArray());
            Console.WriteLine(evens + " " + odds);
        }

    }
}
