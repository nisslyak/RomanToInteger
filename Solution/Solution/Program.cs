using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{
    public static int ConvertToInt(string roman)
    {
        Dictionary<char, int> romanToIntegerDictionary = new Dictionary<char, int>();
        romanToIntegerDictionary.Add('I', 1);
        romanToIntegerDictionary.Add('V', 5);
        romanToIntegerDictionary.Add('X', 10);
        romanToIntegerDictionary.Add('L', 50);
        romanToIntegerDictionary.Add('C', 100);
        romanToIntegerDictionary.Add('D', 500);
        romanToIntegerDictionary.Add('M', 1000);

        int sum = 0;
        int last = 0;
        for (int i = roman.Length - 1; i >= 0; i--)
        {
            int current = romanToIntegerDictionary[roman[i]];
            if (current < last)
            {
                sum -= current;
            }
            else
            {
                sum += current;
            }
            last = current;
        }
        return sum;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        string roman = Console.ReadLine();

        int romanToInteger = Result.ConvertToInt(roman);

        Console.WriteLine(romanToInteger);
    }
}
