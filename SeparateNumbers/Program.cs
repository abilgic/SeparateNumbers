//var str = "7";
//var str = "1234";
using System;
using System.Collections;
using System.Collections.Generic;

var str = "910110";
//var str = "99100";
//var str = "101103";
//var str = "010203";
//var str = "99910001001";

//var str = "429496729542949672964294967297";

//var str = "13";
//var str = "1";
var beautiful = false;
var length = str.Length;
long num1 = 0;
long num2= 0;
long num22 = 0;
long firstsmall = 0;
var numlist1= new List<string>();
var numlist2 = new List<string>();


//first = Convert.ToInt64(str.Substring(i, i));
//second = Convert.ToInt64(str.Substring(i, j));
//Console.WriteLine($"{first} {second}");
//if (second - first == 1)
//{
//    beautiful = true;
//    firstsmall = first;
//    break;
//}

if (length<=1)
{
    return;
}

var firstnumlist = new List<long>();
var secondnumlist = new List<long>();
firstnumlist = firstnumberall(str);
firstnumlist.AddRange(firstnumberInc(str));
secondnumlist = secondnumberall(str);
secondnumlist.AddRange(secondnumberInc(str));

foreach (var item in firstnumlist)
{
    Console.Write($"{item}|");
}
Console.WriteLine();

foreach (var item in secondnumlist)
{
    Console.Write($"{item}|");
}
Console.WriteLine();
////***************************************


//for (int i = 0; i+1 < numlist.Count; i++)
//{
//    Console.Write($"{numlist[i]} |");
//    // first = Convert.ToInt64(str.Substring(i, i));
//    //second = Convert.ToInt64(str.Substring(i, j));

//    if (numlist[i + 1] - numlist[i]==1)
//    {
//        beautiful = true;
//        firstsmall=numlist[i];
//    }

//}
//Console.WriteLine();

//if (beautiful)
//{
//    Console.WriteLine($"YES {firstsmall}");
//}
//else
//{
//    Console.WriteLine($"NO");
//}
//*/

List<long> firstnumberall(string str)
{
    var numlist= new List<long>();
    for (int i = 1; i <= str.Length / 2; i++)
    {
        var num = Convert.ToInt64(str.Substring(0, i));
        numlist.Add(num);
    }
    return numlist;    
}

List<long> secondnumberall(string str)
{
    var numlist = new List<long>();
    for (int i = 1; i + 1 <= str.Length; i++)
    {
        var num = Convert.ToInt64(str.Substring(1, i));
        numlist.Add(num);
    }
    return numlist;
}

List<long> firstnumberInc(string str)
{
    var numlist = new List<long>();
    for (int i = 1; i <= length / 2; i++)
    {
        for (int j = 0; i + j <= length; j += i)
        {
            var num = Convert.ToInt64(str.Substring(j, i));
            numlist.Add(num);
        }
    }
    return numlist;
}

List<long> secondnumberInc(string str)
{
    var numlist = new List<long>();
    for (int i = 1; i <= length / 2; i++)
    {
        for (int j = 1; i + j <= length; j += i)
        {
            var num = Convert.ToInt64(str.Substring(j, i));
            numlist.Add(num);
        }
    }
    return numlist;
}