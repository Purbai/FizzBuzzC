// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

for (int i = 1; i <= 100; i++)
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

    if (str1.Length == 0 )
    {
        str1 = i.ToString();
    }
    Console.WriteLine(str1);
}

// for (int i = 1; i <= 100; i++)
// {
//     string str1 = "";
//     string str2 = "";
//     string str3 = "";
//     string str4 = "";
//     string str5 = "";
//     if (i % 3 == 0)
//     {
//         str1 += "Fizz";
//     }
//     if (i % 5 == 0)
//     {
//         str2 += "Buzz";
//     }
//     if (i % 7 == 0)
//     {
//         str3 += "Bang";
//     }
//     if (i % 11 == 0)
//     {
//         str4 = "Bong";
//     }
//     if (i % 13 == 0)
//     {
//         str5 = "Fezz";
//     }

//     if (str5.Length != 0 )
//     {
//         if (str5.Substring(0,1) == "B")
//         {}
//     }

//     if (str.Length == 0 && str2.Length ==0)
//     {
//         str = i.ToString();
//     }
//     Console.WriteLine(str);
// }


