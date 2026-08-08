using System.IO.Pipelines;
using System.Runtime.InteropServices;

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int periodLocation = 0;
string myString = "";

for (int i = 0; i < myStrings.Length; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    while (periodLocation != -1)
    {
        // places first sentence in mySentence and removes if from myString
        mySentence = myString.Remove(periodLocation);

        // removing the first sentence and period we just added to mySentence
        myString = myString.Substring(periodLocation + 1);

        // removing whitepsace
        myString = myString.TrimStart();

        // updating period location
        periodLocation = myString.IndexOf(".");

        Console.WriteLine("mysentence" + mySentence);
    }

    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}







