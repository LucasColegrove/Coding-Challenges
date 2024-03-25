/*
Challenge Description:
Data comes in many formats.
In this challenge you have to parse the individual "Order IDs", and output the "OrderIDs" sorted.
Tag the order ID as "Error" if they aren't exactly four characters in length.

/////////////////////////////////
Example Output:
A345
B123
B177
B179
C15     - Error
C234
C235
G3003   - Error
/////////////////////////////////

Author: Lucas Colegrove (3/24/24)
*/

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";     //initial given string.

string[] orderArray = orderStream.Split(",");                       //splits string based on comma location and adds the split elements to a string array. 

Array.Sort(orderArray);                                             //sorts the string array 

for (int i = 0; i < orderArray.Length; i++)                         //for loop loops through each element of the string array.
{
    if (orderArray[i].Length != 4)                                  //if statement checks the length of each string array element.
    {
        Console.WriteLine($"{orderArray[i]}\t- Error");
    }
    else
        Console.WriteLine(orderArray[i]);
}


