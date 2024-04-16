/*
PROGRAM DESCRIPTION:
This program reverses each word in a sentence while 
maintaining the original position of each word.

EXAMPLE OUTPUT:
there are snakes at the zoo
ereht era sekans ta eht ooz

AUTHOR: Lucas Colegrove (04/16/2024)    
*/
using System;

string input = "there are snakes at the zoo";
Console.WriteLine(input);
Console.WriteLine(ReverseSentence(input));

string ReverseWord(string word)
{
    string result = "";
    for(int i = word.Length - 1; i >= 0; i--)
    {
        result += word[i];
    }

    return result;
}

string ReverseSentence(string input)
{
    string result = "";
    string[] words = input.Split(" "); 

    foreach (string word in words)
    {
        result += ReverseWord(word) + " ";
    }

    return result.Trim();
}