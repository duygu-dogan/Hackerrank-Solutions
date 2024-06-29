class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        DateOnly returned = DateOnly.ParseExact(Console.ReadLine(), "d M y");
        DateOnly expected = DateOnly.ParseExact(Console.ReadLine(), "d M y");

        if (returned <= expected)
        {
            Console.WriteLine(0);
        }
        else if (returned.Year > expected.Year)
        {
            Console.WriteLine(10000);
        }
        else if (returned.Month > expected.Month)
        {
            Console.WriteLine(500 * (returned.Month - expected.Month));
        }
        else
        {
            Console.WriteLine(15 * (returned.Day - expected.Day));
        }
    }
}
