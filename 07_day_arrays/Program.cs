namespace _07_day_arrays;

class Solution
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
        
        int[] array = arr.ToArray();

        // Array.Reverse(array);

        // foreach (var item in array)
        // {
        //     Console.Write(item + " ");
        // }

        //or
        
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Console.Write(array[i] + " ");
        }
    }
}
