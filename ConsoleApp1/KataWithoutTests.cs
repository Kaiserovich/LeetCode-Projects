using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp
{
    public static class KataWithoutTests
    {
        public static int Search(int[] nums, int target)
        {
            if (nums == null)
                return -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                    return i;
            }
            return -1;
        }

        public static double[] ConvertTemperature(double celsius) =>
             new[] { celsius + 275.15, celsius * 1.80 + 32.00 };
        public static int MaxDistance(int[][] grid)
        {
            int maxDistance = -1;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 0)
                    {
                        int minDistanceLocal = int.MaxValue;
                        for (int k = 0; k < grid.Length; k++)
                        {
                            for (int m = 0; m < grid[k].Length; m++)
                            {
                                if (grid[k][m] == 1)
                                {
                                    minDistanceLocal = Math.Min(minDistanceLocal, Math.Abs(i - k) + Math.Abs(j - m));
                                    /*if (minDistanceLocal == 1)
                                        return minDistanceLocal;*/

                                }
                            }

                        }
                        if (minDistanceLocal != int.MaxValue)
                            maxDistance = Math.Max(maxDistance, minDistanceLocal);
                    }
                }
            }

            return maxDistance;
        }
        public static int[] GetConcatenation(int[] nums)
        {
            return nums.Concat(nums).ToArray();
        }

        public static bool IsSubsequence(string str1, string str2)
        {
            if (str1 == string.Empty)
                return true;

            for (int i = 0, j = 0; j < str2.Length; j++)
            {
                if (str1[i] == str2[j])
                    i++;

                if (i == str1.Length)
                    return true;
            }
            return false;
        }
        public static bool IsIsomorphic(string s, string t)
        {
            var lettersIsomorphicDictionary = new Dictionary<char, char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!lettersIsomorphicDictionary.ContainsKey(s[i]))
                {
                    if (lettersIsomorphicDictionary.ContainsValue(t[i]))
                        return false;

                    lettersIsomorphicDictionary.Add(s[i], t[i]);
                }

                else if (lettersIsomorphicDictionary[s[i]] != t[i])
                    return false;
            }
            return true;
        }
        public static bool CanConstruct(string ransomNote, string magazine)
        {
            if (magazine.Length < ransomNote.Length)
                return false;

            Dictionary<char, int> lettersDictionary = new Dictionary<char, int>();

            foreach (var letter in magazine)
            {
                if (!lettersDictionary.ContainsKey(letter))
                    lettersDictionary.Add(letter, 1);
                else
                    lettersDictionary[letter]++;
            }
            foreach (var letter in ransomNote)
            {
                if (lettersDictionary.ContainsKey(letter))
                {
                    lettersDictionary[letter]--;
                    if (lettersDictionary[letter] < 0)
                        return false;
                }
                else
                    return false;
            }
            return true;

        }
        public static int MaximumWealth(int[][] accounts)
        {
            int max = int.MinValue;
            foreach (int[] account in accounts)
            {
                max = Math.Max(account.Sum(), max);
            }
            return max;
        }


        public static int DescendingOrder(int num) =>
            int.Parse(string.Concat(num.ToString().OrderByDescending(i => int.Parse(i.ToString()))));
        public static string Likes(string[] name)
        {
            switch (name.Length)
            {
                case 0: return "no one likes this";
                case 1: return $"{name[0]} likes this";
                case 2: return $"{name[0]} and {name[1]} like this";
                case 3: return $"{name[0]}, {name[1]} and {name[2]} like this";
                default: return $"{name[0]}, {name[1]} and {name.Length - 2} others like this";
            }
        }

        public static string FindNeedle(object[] haystack) =>
            "found the needle at position " + Array.IndexOf(haystack, "needle");

        public static int TwiceAsOld(int dadYears, int sonYears) =>
            Math.Abs(sonYears * 2 - dadYears);
    }
}
