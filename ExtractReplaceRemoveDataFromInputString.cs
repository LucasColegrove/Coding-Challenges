/*
    Challenge Description:
    1. Begin adding your solution code to the starter code under the comment // Your work here.

    2. Set the quantity variable to the value obtained by extracting the text between the <span> and </span> tags.

    3. Set the output variable to the value of input, then remove the <div> and </div> tags.

    4. Replace the HTML character ™ (&trade;) with ® (&reg;) in the output variable.

    5. Run your solution and verify the output put matches the expected output.

/////////////////////////////////
Example Output:
Quantity: 5000
Output: <h2>Widgets &reg;</h2><span>5000</span>    
/////////////////////////////////
    
Author: Lucas Colegrove (3/27/2024)
*/

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here
//extracts quantity from between <span> tags
int openingPosition = input.IndexOf("<span>");      
int closingPosition = input.IndexOf("</span>");

openingPosition += 6;

int length = closingPosition - openingPosition;

quantity = input.Substring(openingPosition, length);    

//replace html character (&trade) with (&reg) in the output variable
const string tradeTag = "&trade";
const string regTag = "&reg";
output = input.Replace(tradeTag, regTag);

//removing <div> and </div> tags
const string openDiv = "<div>";
int divStart = output.IndexOf(openDiv);
output = output.Remove(divStart, openDiv.Length);

const string endDiv = "</div>";
int divEnd = output.IndexOf(endDiv);
output = output.Remove(divEnd, endDiv.Length);

Console.WriteLine($"Quantity: {quantity}");
Console.WriteLine($"Output: {output}");

