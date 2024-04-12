/*
PROGRAM DESCRIPTION:
    This program tells your fortune based on how much "luck" you have (assigned via a random value). A ternary conditional operator with 
    another nested inside of it is used to select which string array (good, bad, or neutral) will be used when constructing your fortune!

EXAMPLE OUTPUT:
    A fortune teller whispers the following words:
    You have much to fear. Today is a day to avoid major decisions. Whatever work you do may have unexpected outcomes. This is an ideal time to re-evaluate your life.

Author: Lucas Colegrove (4/11/2024)
*/
using System;

Random random = new Random();
int luck = random.Next(100);

string[] text = {"You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"};
string[] good = {"look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"};
string[] bad = {"fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."};
string[] neutral = {"appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."};

FortuneMethod();

void FortuneMethod()
{
    Console.WriteLine("A fortune teller whispers the following words:");

    string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
    
    for (int i = 0; i < 4; i++) 
    {
        Console.Write($"{text[i]} {fortune[i]} ");
    }    
    Console.WriteLine();
}