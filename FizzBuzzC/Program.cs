// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

for (int i = 1; i <= 200; i++)
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
        int charPos = str1.IndexOf("B");
        if (charPos != -1)
        {
            str1 = string.Concat(str1.Substring(0,charPos),str2,str1.Substring(charPos));
        }
    }
    Console.WriteLine(str1);
}
