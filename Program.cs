string[] myStrings = new string[2]
{ "I like pizza. I like roast chicken. I like salad",
"I like all three of the menu choices"
};

int periodLocation;

foreach (var myString in myStrings)
{
    do
    {
        periodLocation = myString.IndexOf(".");

        if (periodLocation != -1)
        {
            myString.Remove(periodLocation).Substring(periodLocation + 1).TrimStart();
            Console.WriteLine("");
        }

    } while (periodLocation == -1);
}