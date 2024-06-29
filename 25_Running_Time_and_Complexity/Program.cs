namespace _25_Running_Time_and_Complexity;
// A prime is a natural number greater than  that has no positive divisors other than 1 and itself. Given a number, n, determine and print whether it is Prime or Not Prime.

// Note: If possible, try to come up with a  primality algorithm, O(√n) or see what sort of optimizations you come up with for an O(n) algorithm. Be sure to check out the Editorial after submitting your code.
class Solution {
    static void Main(String[] args) {
        int[] arr = GetNumber();
        for (int i = 0; i < arr.Length; i++)
        {
            if(IsPrime(arr[i]))
            {
                Console.WriteLine("Prime");
            }else
            {
                Console.WriteLine("Not prime");
            }
        }
       

    }
    static int[] GetNumber()
    {
        int T=Int32.Parse(Console.ReadLine());
        int[] arr = new int[T];
        for (int i = 0; i < T; i++)
        {
            int a = Int32.Parse(Console.ReadLine());
            arr[i] = a;
        }
        return arr;
    }
    static bool IsPrime(int n)
    {
        if(n == 1)
        return false;
        //Since the square of the divisor of a number is less than or equal to the number, we do not have to check all numbers up to the number we are testing. We only check the divisors in turn, which reduces the time complexity to O(√n).
        for (int i = 2; i*i <= n; i++)
        {
            if(n % i == 0)
            {
                return false;
            }          
        }
        return true;
    }
}
