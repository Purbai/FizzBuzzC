// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

Console.WriteLine("Hello, World!");

Console.WriteLine("Enter starting loop number:");
int startLoop = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter max loop number:");
int maxLoop = Convert.ToInt32(Console.ReadLine());
Console.Write("You have enter: ");
Console.Write(maxLoop);
Console.WriteLine("");

for (int i = startLoop; i <= maxLoop+1; i++)
{
    string str1 = "";
    string str2 = "";

    if (i % 3 == 0)
    {
        str1 += "Fizz";
    }
    if (i % 5 == 0)
    {
        str1 += "Buzz";
    }
    if (i % 7 == 0)
    {
        str1 += "Bang";
    }
    if (i % 11 == 0)
    {
        str1 = "Bong";
    }
    if (i % 13 == 0)
    {
        str2 = "Fezz";
    }
    if (i % 17 == 0)
    {
        // Reverse the order before adding the rule 13
        int strSize = str1.Length;
        int noOfRules = strSize/4;
        string newRevString ="";
        int startPos = strSize ;
        for (int j = noOfRules; j > 0; j--)
        {
            startPos = startPos-4;
            newRevString = string.Concat(newRevString,str1.Substring(startPos,4));
        }
        str1 = newRevString;
    }

    if (str1.Length == 0 && str2.Length==0)
    {
        str1 = i.ToString();
    }
    else if (str2.Length!=0 && str1.Length == 0 )
    {
        str1 = str2;
    }
    else if (str2.Length!=0 && str1.Length != 0 )
    {
        // add run 13 after the reverse
        int charPos = str1.IndexOf("B");
        if (charPos != -1)
        {
            str1 = string.Concat(str1.Substring(0,charPos),str2,str1.Substring(charPos));
        }
    }

    Console.WriteLine(str1);
}
