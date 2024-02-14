using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

// Given an array, a, of size n distinct elements, sort the array in ascending order using the Bubble Sort algorithm above. Once sorted, print the following 3 lines:

// Array is sorted in numSwaps swaps.
// where numSwaps is the number of swaps that took place.
// First Element: firstElement
// where firstElement is the first element in the sorted array.
// Last Element: lastElement
// where lastElement is the last element in the sorted array.
// Hint: To complete this challenge, you will need to add a variable that keeps a running tally of all swaps that occur during execution.

class Solution
{
    public static void Swap(int [] arr, int x, int y)
    {
        int a = arr[x];
        arr[x] = arr[y];
        arr[y] = a;
    }
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
        int[] arr = a.ToArray();
        int numSwaps = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n-1; j++)
            {
                if (arr[j]>arr[j+1])
                {
                    Swap(arr, j, j+1);
                    numSwaps++;
                };
            };
        };
        Console.WriteLine($"Array is sorted in {numSwaps} swaps.");
        Console.WriteLine($"First Element: {arr[0]}");
        Console.WriteLine($"Last Element: {arr[arr.Length-1]}");

    }
}
