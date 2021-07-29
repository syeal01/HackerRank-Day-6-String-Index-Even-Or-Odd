using System;
using System.Collections.Generic;
using System.IO;
class Solution 
{
    static void Main(String[] args) 
    {
        int n = Convert.ToInt32(Console.ReadLine());

        for (int j = 0; j < n; j++)
        {
            string s = Console.ReadLine();

            for (int i = 0; i < s.Length; i=i+2)
                System.Console.Write(s[i]);
            System.Console.Write(" ");
            for (int i = 1; i < s.Length; i=i+2)
                System.Console.Write(s[i]);
            System.Console.WriteLine("");
        }
    }
}
