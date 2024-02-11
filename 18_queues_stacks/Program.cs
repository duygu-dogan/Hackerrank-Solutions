﻿using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    //1. Two instance variables: one for your stack, and one for your queue.
    Stack<char> stack = new Stack<char>();
    Queue<char> queue = new Queue<char>();
    //2. A void pushCharacter(char ch) method that pushes a character onto a stack.
    void pushCharacter(char ch)
    {
        stack.Push(ch);
    } 
    //3. A void enqueueCharacter(char ch) method that enqueues a character in the queue instance variable.
    void enqueueCharacter(char ch)
    {
        queue.Enqueue(ch);
    }
    //4. A char popCharacter() method that pops and returns the character at the top of the stack instance variable.
    char popCharacter()
    {
        return stack.Pop();
    }
    //5. A char dequeueCharacter() method that dequeues and returns the first character in the queue instance variable.
    char dequeueCharacter()
    {
        return queue.Dequeue();
    }


    static void Main(String[] args) {
        // read the string s.
        string s = Console.ReadLine();
        
        // create the Solution class object p.
        Solution obj = new Solution();
        
        // push/enqueue all the characters of string s to stack.
        foreach (char c in s) {
            obj.pushCharacter(c);
            obj.enqueueCharacter(c);
        }
        
        bool isPalindrome = true;
        
        // pop the top character from stack.
        // dequeue the first character from queue.
        // compare both the characters.
        for (int i = 0; i < s.Length / 2; i++) {
            if (obj.popCharacter() != obj.dequeueCharacter()) {
                isPalindrome = false;
                
                break;
            }
        }
        
        // finally print whether string s is palindrome or not.
        if (isPalindrome) {
            Console.Write("The word, {0}, is a palindrome.", s);
        } else {
            Console.Write("The word, {0}, is not a palindrome.", s);
        }
    }
}