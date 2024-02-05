using System.Security.Cryptography.X509Certificates;
using System;

namespace _14_scope;

// Task
// Complete the Difference class by writing the following:

// A class constructor that takes an array of integers as a parameter and saves it to the __elements instance variable.
// A computeDifference method that finds the maximum absolute difference between any 2 numbers in __elements and stores it in the maximumDifference instance variable.
class Difference {
    private int[] elements;
    public int maximumDifference;

    public Difference(int[] a)
    {
        elements = a;
        
    }
	public void computeDifference()
    {
        // List<int> results = new();
        // for (int i = 0; i < elements.Length -1; i++)
        // {
        //     for (int j = i + 1; j < elements.Length; j++)
        //     {
        //         results.Add(Math.Abs(elements[i] -elements[j]));
        //     }
        // }
        // maximumDifference = results.Max();

        //shorter solution
        int a = elements.Max();
        int b = elements.Min();
        maximumDifference = Math.Abs(a - b);
    }

} 

class Solution {
    static void Main(string[] args) {
        Convert.ToInt32(Console.ReadLine());
        
        int[] a = Console.ReadLine().Split(' ').Select(x=>Convert.ToInt32(x)).ToArray();
        
        Difference d = new Difference(a);
        
        d.computeDifference();
        
        Console.Write(d.maximumDifference);
    }
}