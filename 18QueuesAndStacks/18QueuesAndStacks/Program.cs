using System;
using System.Collections;
using System.Collections.Generic;

namespace _18QueuesAndStacks
{
    class Solution
    {
        private Stack<char> charStack = new Stack<char>();
        private Queue<char> charQueue = new Queue<char>();

        void pushCharacter(char ch)
        {
            // pushes a character onto a stack.
            charStack.Push(ch);
        }

        char popCharacter()
        {
            // A char popCharacter() method that pops and returns the character at the top of the stack instance variable.
            return charStack.Pop();
        }

        void enqueueCharacter(char ch)
        {
            // enqueues a character in the queue instance variable.
            charQueue.Enqueue(ch);
        }

        char dequeueCharacter()
        {
            // dequeues and returns the first character in the queue instance variable.
            return charQueue.Dequeue();
        }

        static void Main(String[] args)
        {
            // read the string s.
            Console.WriteLine("type 8 char string all uppercase or all lowercase");
            string s = Console.ReadLine();

            // create the Solution class object p.
            Solution obj = new Solution();

            // push/enqueue all the characters of string s to stack.
            foreach (char c in s)
            {
                obj.pushCharacter(c);
                obj.enqueueCharacter(c);
            }

            bool isPalindrome = true;

            // pop the top character from stack.
            // dequeue the first character from queue.
            // compare both the characters.
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (obj.popCharacter() != obj.dequeueCharacter())
                {
                    isPalindrome = false;

                    break;
                }
            }

            // finally print whether string s is palindrome or not.
            if (isPalindrome)
            {
                Console.WriteLine("The word, {0}, is a palindrome.", s);
            }
            else
            {
                Console.WriteLine("The word, {0}, is not a palindrome.", s);
            }
        }
    }
}

/*
 
The Stacks and Queues here are done using the Stack and Queue classes in C#
They can also be done manually via other approaches.

    private Stack<char> charStack = new Stack<char>();
    private Queue<char> charQueue = new Queue<char>();


Alternative that does not use the C# classes from system.generic

    List<char> charStack = new List<char>();
    List<char> charQueue = new List<char>();

 */

/*

Alt approach: using a List of chars instead of C# Classes

NOTE - notice the changes in the methods. 
* Add() instead of Push() and manual code logic instead of Pop() *
 
    List<char> charStack = new List<char>();
    List<char> charQueue = new List<char>();
    
    void pushCharacter(char ch) {
        charStack.Add(ch);
    }

     char popCharacter() {
        char returnChar = charStack[charStack.Count - 1];
        charStack.RemoveAt(charStack.Count - 1);
        return returnChar;  
     }
    
    void enqueueCharacter(char ch) {
        charQueue.Add(ch);
    }
              
    char dequeueCharacter() {
        char returnChar = charQueue[0];
        charQueue.RemoveAt(0);
        return returnChar;       
    }

 */
