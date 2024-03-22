/*
    This program takes every word in a sentence and reverses each individual word.

    Example: "The quick brown fox jumps over the lazy dog"
             "ehT kciuq nworb xof spmuj revo eht yzal god"

    Author: Lucas Colegrove 3/22/24         
*/
string pangram = "The quick brown fox jumps over the lazy dog";

string[] words = pangram.Split(" ");

string[] newMessage = new string[words.Length];

for (int i = 0; i < words.Length; i++)
{
    char[] letters = words[i].ToCharArray();
    Array.Reverse(letters);
    newMessage[i] = new string (letters);
} 

string result = String.Join(" ", newMessage);
Console.WriteLine(result);

