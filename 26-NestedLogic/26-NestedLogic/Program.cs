class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        DateTime returned = DateConverter(Console.ReadLine());
        DateTime expected = DateConverter(Console.ReadLine());

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
    static DateTime DateConverter(string date)
    {
        string[] dateString = date.Split(' ');
        if (dateString.Length != 3)
        {
            throw new ArgumentException("Invalid date format");
        }
        else
        {
            int day = int.Parse(dateString[0]);
            int month = int.Parse(dateString[1]);
            int year = int.Parse(dateString[2]);
            return new DateTime(year, month, day);
        }
    }
}
