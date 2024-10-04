﻿string[] myStrings = ["I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices"];

string myString = "";
int periodLocation = 0;

for (int i = 0; i < myStrings.Length; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    while (periodLocation != -1)
    {

        mySentence = myString.Remove(periodLocation);

        myString = myString.Substring(periodLocation + 1).TrimStart();

        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }
 
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}