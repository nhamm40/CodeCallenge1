﻿using System;
using vAutoChallenge.Managers;

//Dear candidate,
//Below you will see the requirements of a program.In order to be considered for a technical phone
//interview with our hiring manager and team we want to assess your ability to problem solve, analyze
//requirements, and write code.

//PP 1.6: In the programming language of your choice, write a method that modifies a string using the
//following rules:

//1. Each word in the input string is replaced with the following: the first letter of the word, the count of
//distinct letters between the first and last letter, and the last letter of the word.For
//example, “Automotive parts" would be replaced by "A6e p3s".
//2. A "word" is defined as a sequence of alphabetic characters, delimited by any non-alphabetic
//characters.
//3. Any non-alphabetic character in the input string should appear in the output string in its original
//relative location.
//We are looking for accuracy, efficiency and solution completeness. Please include this problem
//description in the comment at the top of your solution. The problem is designed to take approximately
//1-2 hours.

namespace vAutoChallenge
{
    internal class Program
    {
        private static readonly IStringManager StringManager = new StringManager();

        private static void Main()
        {
            Console.WriteLine("Please enter a string of words. (The string can be any number of words)");
            var inputString = Console.ReadLine();

            var result = StringManager.StringModifier(inputString);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
