# STRING PERMUTATIONS (Exercise sourced from FutureSkills)

Welcome to the world of cryptography! You have been recruited by the top-secret agency and are now part of a team responsible for creating unbreakable codes to secure confidential information.
Your team leader, Ada, has given you the task of creating a program that can generate a secret code that can be used to communicate top-secret messages between agents. The code needs to be generated from an array
of strings, where each string represents a message that needs to be encrypted.
Ada has told you that the code should be the shortest possible string that contains all the letters in the input strings, sorted from a to z. She has also assured you that the input strings will always contain
only lowercase letters a-z.
Your mission is to write a program that can handle this task and generate the secret code that will be used by the agents to securely communicate their messages.
Example:
Input array: ["ab", "ba", "aa"].
Correct answer: "aab" 
The reason the answer is "aab" is that all input strings can be created by picking letters from the answer string in any order. The letters 'a' and 'b' are used twice in the input strings, and the 
shortest string that contains all these letters is "aab", which is sorted from a to z.

# SOLUTION

using API;
using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Solution
{
    public class Solution : ISolution
    {
        private APICaller api;

        public Solution(APICaller api)
        {
            this.api = api;
            Console.WriteLine("Press run code to see this in the console!");
            // You can initiate and calculate things here
        }

        /**
         * Print the shortest possible string that contains all the letters in
         * the input strings (the parameter 'list of strings'), sorted from a to
         * z. The input strings will always contain only lowercase letters a-z.
         */
        public string Level1CommonLetters(List<string> listOfStrings)
        {
           // Initializing the result string with the first string
             StringBuilder resStr = new(listOfStrings[0]);

           // Logic for appending all the occurences of each letter from each of the input strings
               for (int i = 1; i < listOfStrings.Count; i++)
               {
                   char[] charInpStr = listOfStrings[i].ToCharArray();
                   for (int j = 0; j < charInpStr.Length; j++)
                   {
                       int countResStr = resStr.ToString().Count(c => c == charInpStr[j]);
                       int countInpStr = listOfStrings[i].Count(c => c == charInpStr[j]);
                       if (countInpStr > countResStr)
                       {
                           int numCharsTobeAdded = countInpStr - countResStr;
                           while (numCharsTobeAdded > 0)
                           {
                               resStr.Append(charInpStr[j]);
                               numCharsTobeAdded--;
                           }
                       }
                   }
               }
           // Sorting the final string in an alphabetical order
           char[] charResStr = resStr.ToString().ToCharArray();
           Array.Sort(charResStr);
           String strResult = new(charResStr);
           Console.WriteLine($"The Shortest encrypted string : {strResult}");
        }
    }
}

