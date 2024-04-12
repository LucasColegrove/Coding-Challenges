/*
PROGRAM DESCRIPTION:
This program adjusts scheduled times to a different GMT time zone.
The method DisplayAdjustedTimes takes a schedule of different times, the current Greenwich Mean Time (GMT) zone, and
the new GMT time zone you are converting to as parameters.

EXAMPLE OUTPUT:
    800 -> 2000
    1200 -> 0
    1600 -> 400
    2000 -> 800

AUTHOR: Lucas Colegrove (04/12/2024)    
*/
using System;

int[] schedule = {800, 1200, 1600, 2000};  //array containing different schedule times

DisplayAdjustedTimes(schedule, 6, -6);

void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT)
{
    int diff = 0;      //stores time difference
    
    if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)                    //checks to make sure provided GMT values are between -12 and 12
    {
        Console.WriteLine("Invalid GMT");
    }
    else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) //if newGMT AND currentGMT both <= 0 OR new AND current both >=0...
    {
        diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));                //then time difference = Abs(newGMT) - Abs(currentGMT)
    } 
    else 
    {
        diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));                //else time difference = Abs(newGMT) + Abs(currentGMT)
    }

    for (int i = 0; i < times.Length; i++) 
    {
        int newTime = ((times[i] + diff)) % 2400;                              //New time is equal to schedule time + calculated time difference ^
        Console.WriteLine($"{times[i]} -> {newTime}");
    }
}