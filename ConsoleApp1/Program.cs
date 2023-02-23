using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    public static class Kata
    {

        static void Main(string[] args)
        {
            Console.ReadKey();
        }
        public static double[] ConvertTemperatureBranch(double celsius) =>
            new[] { celsius + 275.15, celsius * 1.80 + 32.00 };
        public static int[][] FloodFill(int[][] image, int sr, int sc, int color)
        {
            int hieght = image.Length;
            int width = image[0].Length;
            bool[][] mask = new bool[hieght][];
            for (int i = 0; i < hieght; i++)
                mask[i] = new bool[width];

            if (image[sr][sc] == color)
                return image;

            int changeableColor = image[sr][sc];
            Queue<Coordinates> queueCheck = new Queue<Coordinates>();
            Coordinates coord = new Coordinates { x = sr, y = sc };
            queueCheck.Enqueue(coord);
            while(queueCheck.Count > 0)
            {
                coord = queueCheck.Dequeue();
                mask[coord.x][coord.y] = true;


                for (int i = 0; i < 4; i++)
                {
                    int shiftX = coord.x;
                    int shiftY = coord.y;
                    switch (i) {
                        case 0:
                            shiftX = coord.x - 1;
                            break;
                        case 1:
                            shiftX = coord.x + 1;
                            break;
                        case 2:
                            shiftX = coord.x;
                            shiftY = coord.y - 1;
                            break;
                        case 3:
                            shiftY = coord.y + 1;
                            break;
                    }

                    if (!CheckOutOfRange(shiftX,shiftY,hieght,width) && 
                        image[shiftX][shiftY] == changeableColor && 
                        mask[shiftX][shiftY] != true)
                    {
                        mask[shiftX][shiftY] = true;
                        queueCheck.Enqueue(new Coordinates { x = shiftX, y = shiftY });
                    }
                }

            }
            for (int i = 0; i < hieght; i++)
                for (int j = 0; j < width; j++)
                    if (mask[i][j] == true)
                        image[i][j] = color;
            return image;
        }
        struct Coordinates { public int x, y; }
        static bool CheckOutOfRange(int x, int y, int hight, int width)
        {
            if(x < 0 || x >= hight|| y < 0 || y >= width)
                return true;
            return false;
        }
        public static int Search(int[] nums, int target) {
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
             new [] {celsius + 275.15, celsius* 1.80 + 32.00};
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
                    if(lettersIsomorphicDictionary.ContainsValue(t[i]))
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
        public static int NumberOfSteps(int num)
        {
           return num == 0 ? 0 : num % 2 == 0 ? NumberOfSteps(num / 2) + 1 : NumberOfSteps(num - 1) + 1;
        }
        public static IList<string> FizzBuzz(int n) => 
            Enumerable.Range(1, n).Select(i => (i % 3 == 0 && i % 5 == 0 ? "FizzBuzz" : (i % 3 == 0) ? "Fizz" : (i % 5 == 0) ? "Buzz" : i.ToString())).ToList();
        public static int MaximumWealth(int[][] accounts)
        {
            int max = int.MinValue;
            foreach (int[] account in accounts)
            {
                max = Math.Max(account.Sum(), max);
            }
            return max;
        }

        public static bool Comp(int[] a, int[] b)
        {

            if (a == null || b == null || a.Length != b.Length || a.Length == 0)
                return false;
            var d = a.Where(x => b.Contains(x) || b.Contains((int)(Math.Sqrt(x))) || b.Contains(x * x)).Select(x => -1);
            var d1 = d.Any();
            var d2 = d.All(x => x == -1);
           // var c = a.Where(x => b.Contains(x) || b.Contains((int)(Math.Sqrt(x))) || b.Contains(x * x)).Select(x => -1).Any().All(x => x == -1);

            foreach (var item in a)
            {
                Console.Write(item + " Count:" + a.Length);
            }
            Console.WriteLine();
            foreach (var item in b)
            {
                Console.Write(item + " Count:" + b.Length);
            }
            // your code

            return d.Any() && d.All(x => x == -1);


        }
        public static bool IsSquare(int n) =>
            Math.Sqrt(n) % 1 == 0;
        public static string DuplicateEncode(string word) =>
            string.Concat(word
                .ToLower()
                .Select(x => (string.Concat(word.ToLower()
                    .GroupBy(e => e)
                    .Where(g => g.Count() > 1)
                    .Select(y => y.Key)))
                .Contains(x) ? ")": "("));

        public static string AddBinary(int a, int b) =>
            Convert.ToString(a + b, 2);


        static int DescendingOrder(int num) => 
            int.Parse(string.Concat(num.ToString().OrderByDescending(i => int.Parse(i.ToString()))));

        public static bool ValidatePin(string pin) =>
             ((pin.Length == 4 || pin.Length == 6) && pin.All(char.IsDigit));

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

        public static int GetGoals(int laLigaGoals, int copaDelReyGoals, int championsLeagueGoals) =>
            laLigaGoals + copaDelReyGoals + championsLeagueGoals;

        public static string FindNeedle(object[] haystack) => 
            "found the needle at position " + Array.IndexOf(haystack, "needle");
        public static int PositiveSum(int[] arr) =>
            arr.Where(x => x > 0).Sum();
        public static int TwiceAsOld(int dadYears, int sonYears) =>
            Math.Abs(sonYears * 2 - dadYears);
    }
}

