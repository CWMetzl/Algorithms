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
     * Complete the 'minimumNumber' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. STRING password
     */

    public static int minimumNumber(int n, string password)
    {
    // Return the minimum number of characters to make the password strong
        bool lengthGood = false;
        bool hasDigit = false;
        bool hasLc = false;
        bool hasUc = false;
        bool hasSpecial = false;
        lengthGood = n >= 6;
        hasDigit = password.IndexOfAny("0123456789".ToCharArray()) != -1;
        hasLc = password.IndexOfAny("abcdefghijklmnopqrstuvwxyz".ToCharArray()) != -1;
        hasUc = password.IndexOfAny("ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray()) != -1;
        hasSpecial = password.IndexOfAny("!@#$%^&*()-+".ToCharArray()) != -1;
        int minNumToAdd  = (6 - n) > 0 ? 6 - n : 0;
        int minCharsMissing = 0;
        if (!hasDigit) minCharsMissing++;
        if (!hasLc) minCharsMissing++;
        if (!hasUc) minCharsMissing++;
        if (!hasSpecial) minCharsMissing++;
        return minNumToAdd > minCharsMissing ? minNumToAdd : minCharsMissing;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        string password = Console.ReadLine();

        int answer = Result.minimumNumber(n, password);

        textWriter.WriteLine(answer);

        textWriter.Flush();
        textWriter.Close();
    }
}
