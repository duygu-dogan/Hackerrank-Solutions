namespace _10_binary_numbers;

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        
        string newNumS = getBinary(n);
        var result = newNumS.Split("0").OrderByDescending(x => x.Length);
       Console.WriteLine(result.First().Length);
    

    // short version
    // var b = Convert.ToString(n, 2).Split('0')
	// 		.OrderByDescending(x => x.Length);
	// Console.WriteLine(b.First().Length);

    }
    public static string getBinary(int n)
    {
        List<int> newNum = new List<int>();
        while (n > 0)
        {
            int remainder = n % 2;
            newNum.Add(remainder);
            n = n / 2;
        }
        string newNumS = string.Join( "", newNum);
        return newNumS;
    }
}
