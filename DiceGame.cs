/*
PROGRAM DESCRIPTION:
Mini Game where a target number is chosen between 1 and 5. The player
roles a 6 sided dice and if their roll is greater than the target they win.

EXAMPLE OUTPUT:
Would you like to play? (Y/N)
Y
Roll a number greater than 2 to win!
You rolled a 1
You lose!

AUTHOR: Lucas Colegrove (04/18/2024)    
*/
using System;

Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay()) 
{
    PlayGame();
}

void PlayGame() 
{
    var play = true;

    while (play) 
    {
        var target = TargetNumber();
        var roll = RollDice();

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(roll, target));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

int RollDice()
{
    return random.Next(1, 7);
}

int TargetNumber()
{
    return random.Next(1, 6);
}

bool ShouldPlay()
{
    string response = Console.ReadLine();
    return response.ToLower().Equals("y");    
}

string WinOrLose(int roll, int target)
{
    if (roll > target)
    {
        return "You win!";
    }
    return "You lose!";
}