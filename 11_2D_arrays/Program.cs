namespace _11_2D_arrays;

class Solution
{
    // Calculate the hourglass sum for every hourglass in A, then print the maximum hourglass sum.
    public static void Main(string[] args)
    {

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < 6; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }
        int count = 0;
        List<int> counts = new List<int>();
        for (int i = 0; i <= 3; i++)
        {
            for (int j = 0; j <= 3; j++)
            {
                count = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] + arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j +2];  
                counts.Add(count);
                count = 0;
            }
            
        }
        Console.WriteLine(counts.Max());
    }
}
