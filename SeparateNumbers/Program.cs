//var str = "7";
//var str = "1234";
using System;
using System.Collections;
using System.Collections.Generic;
long b = 0;
string a = "", c = "";
var str = "1234";
//var str = "91011";
//var str = "99100";
//var str = "101103";
//var str = "010203";
//var str = "13";
//var str = "1";
//var str = "99910001001";
//var str = "429496729542949672964294967297";
var length=str.Length;

for (int i = 1; i <= length/2; i++)
{
    a = "";
    c = str.Substring(0, i);
    b = long.Parse(c);

    while (a.ToString().Length < str.Length)
    {
        a += b;
        b++;
        Console.WriteLine($"{a}|{b}");
    }
    if (a.Equals(str))
    {
        Console.WriteLine("YES " + c);
        return;
    }
}

