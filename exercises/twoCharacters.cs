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

    /*
     * Complete the 'alternate' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING s as parameter.
     */

    public static int alternate(string s)
    {

    }

    public static void AddToDict(Dictionary<char, int> dict, char value) {
        int count = 0;
        if (dict.ContainsKey(value)) count = dict[value];
        dict[value] = ++count;
    }

    public static bool isAlternating(string s) 
    {
        var chars = new Dictionary<char, int>();
        char first = null;
        char next = null;
        foreach(char c in s) {
            if(first == null)  {
                first = c;
            } else {
                next = c;
            }
            AddToDict(chart, c);
            if(chars.count > 2) return false;
        }
        return true;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int l = Convert.ToInt32(Console.ReadLine().Trim());

        string s = Console.ReadLine();

        int result = Result.alternate(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
