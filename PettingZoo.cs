/*
PROGRAM DESCRIPTION:
This program coordinates school visits for a petting zoo. The zoo is home to 18 different species of animals. 
At the zoo, visiting students are assigned to groups, and each group has a set of animals assigned to it. 
After visiting their set of animals, the students will rotate groups until they've seen all the animals at the petting zoo.

- The program is set up to demonstrate three visiting schools
    - School A has six visiting groups (the default number)
    - School B has three visiting groups
    - School C has two visiting groups

- For each visiting school, the following tasks are performed
    - Animal order is randomized to ensure creation of unique groups
    - Animals are assigned to the correct number of groups
    - School name as well as each animal group is printed


EXAMPLE OUTPUT:
School A
Group 1: kangaroos  lemurs  pigs  
Group 2: alpacas  sheep  chickens  
Group 3: ducks  geese  capybaras  
Group 4: ponies  iguanas  tortoises  
Group 5: ostriches  llamas  rabbits  
Group 6: macaws  goats  emus  
School B
Group 1: llamas  ducks  ponies  geese  chickens  goats
Group 2: iguanas  capybaras  macaws  kangaroos  rabbits  sheep
Group 3: lemurs  tortoises  alpacas  pigs  emus  ostriches
School C
Group 1: sheep  ducks  pigs  macaws  kangaroos  ostriches  rabbits  goats  lemurs
Group 2: iguanas  capybaras  chickens  emus  tortoises  geese  ponies  alpacas  llamas


AUTHOR: Lucas Colegrove (04/18/2024)    
*/
using System;

string[] pettingZoo =                                         //represents species at petting zoo 
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

PlanSchoolVisit("School A");
PlanSchoolVisit("School B", 3);
PlanSchoolVisit("School C", 2);

void PlanSchoolVisit(string schoolName, int groups = 6)
{
    RandomizeAnimals();
    string[,] group = AssignGroup(groups);
    Console.WriteLine(schoolName);
    PrintGroup(group);
}

void RandomizeAnimals()                 //randomize petting zoo array
{
    Random random = new Random();

    for (int i = 0; i < pettingZoo.Length; i++)     //code block cycles through each array element
    {                                                  //swaps element at current index (i) with element at random index (r)
        int r = random.Next(i, pettingZoo.Length);  //range of randomly selected index excludes values less than i

        string temp = pettingZoo[i];
        pettingZoo[i] = pettingZoo[r];
        pettingZoo[r] = temp;
    }    
}

string[,] AssignGroup(int groups = 6)   //assigns animals to a subset group
{
    string[,] result = new string[groups, pettingZoo.Length/groups];

    int start = 0;
    
    for (int i = 0; i < groups; i++)    //iterate through number of groups
    {
        for (int j = 0; j < result.GetLength(1); j++)   //iterates for number of animals group should contain
        {
            result[i, j] = pettingZoo[start++];         //populate 2D array with randomized animal, pettingZoo[0], [1], ...
        }
    }

    return result;
}

void PrintGroup(string[,] group)
{
    for (int i = 0; i < group.GetLength(0); i++) //GetLength(0) is number of rows in group 2D array. GetLength(1) is columns.
    {
        Console.Write($"Group {i + 1}: ");

        for (int j = 0; j < group.GetLength(1); j++) 
        {
            Console.Write($"{group[i,j]}  ");   //outer loop selects row then inner loop prints each animal in row. [0,0], [0,1], [0,2]
        }
        Console.WriteLine();
    }
}