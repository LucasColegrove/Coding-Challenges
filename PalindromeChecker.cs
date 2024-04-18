/*
PROGRAM DESCRIPTION:
This program checks if each string in a string array is a 
palindrome or not.

EXAMPLE OUTPUT:
Is it a palindrome?
racecar: True
talented: False

AUTHOR: Lucas Colegrove (04/18/2024)    
*/
using System;

string[] words = {"racecar" ,"talented", "deified", "tent", "tenet"};

Console.WriteLine("Is it a palindrome?");

foreach (string word in words) 
{
    Console.WriteLine($"{word}: {IsPalindrome(word)}");
}

bool IsPalindrome(string word) 
{
    int start = 0;
    int end = word.Length - 1;

    while (start < end)
    {
        if (word[start] != word[end])
        {
            return false;
        }
        start++;
        end--;
    }

    return true;
}