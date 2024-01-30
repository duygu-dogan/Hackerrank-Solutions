namespace _05_day_loops;

class Solution
{
    // Given an integer, n, print its first 10 multiples. Each multiple n x i (where 1 <= i <= 10) should be printed on a new line in the form: n x i = result.
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        for (int i = 1; i <= 10; i++)

        {
            if (n <= 2 && n >= 20)
                n *= i;
            Console.WriteLine(n + " x " + i + " = " + n * i);

        }
    }
}
