string[] myStrings = new string[2] { "I like deepdish Pizza. I like roast chicken. I like salad", "I like all 3(33) of the menu choices" };
int stringsCount = myStrings.Length;
string myString = "";
int periodLocation = 0;
for (int i=0; i<stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");
    string mySentence;
    while (periodLocation != -1)
    {
        mySentence = myString.Remove(periodLocation);
        myString = myString[(periodLocation + 1)..];
        myString = myString.TrimStart();
        periodLocation = myString.IndexOf(".");
        Console.WriteLine(mySentence);
    }
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);

}
