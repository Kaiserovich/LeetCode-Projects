using System;
using System.Net.Http;
using System.Net;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace PracticeConsoleApp
{
    static internal class TaskForTestingCentaurea
    {
        static string sortAndMerge(string[] words) => string.Join(" ", words.OrderBy(x => x, new VowelsStringComparer()));

        class VowelsStringComparer : IComparer<String>
        {
            public int Compare(string x, string y)
            {
                int xVowels = 0;
                int yVowels = 0;

                for (int i = 0; i < x.Length; i++)
                    if (x.Contains("a") || x.Contains("e") || x.Contains("i") || x.Contains("o") || x.Contains("u"))
                        xVowels++;
                for (int i = 0; i < y.Length; i++)
                    if (y.Contains("a") || y.Contains("e") || y.Contains("i") || y.Contains("o") || y.Contains("u"))
                        yVowels++;

                return xVowels - yVowels;
            }
        }

    }
}

/*
 Write a function (and write its code in the answer) that takes n words as input and returns a sentence in which these words are sorted by the number of vowels
 */