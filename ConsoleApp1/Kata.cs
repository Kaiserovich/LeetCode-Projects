using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp
{
    public static partial class Kata
    {
        public static bool CheckForFactor(int num, int factor) => num % factor == 0;
        public static bool IsCube(double volume, double side) => Math.Pow(volume, 1.0 / 3) == side && side > 0;
        public static int CountSheeps(bool[] sheeps) => sheeps.Count(x => x);
        public static bool Xor(bool a, bool b) => a != b;
        public static int PositiveSum(int[] arr) =>
            arr.Where(x => x > 0).Sum();
        public static int GetGoals(int laLigaGoals, int copaDelReyGoals, int championsLeagueGoals) =>
            laLigaGoals + copaDelReyGoals + championsLeagueGoals;
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
                .Contains(x) ? ")" : "("));

        public static string AddBinary(int a, int b) =>
            Convert.ToString(a + b, 2);
        public static bool ValidatePin(string pin) =>
             ((pin.Length == 4 || pin.Length == 6) && pin.All(char.IsDigit));
        public static IList<string> FizzBuzz(int n) =>
            Enumerable.Range(1, n).Select(i => (i % 3 == 0 && i % 5 == 0 ? "FizzBuzz" : (i % 3 == 0) ? "Fizz" : (i % 5 == 0) ? "Buzz" : i.ToString())).ToList();

        public static int NumberOfSteps(int num)
        {
            return num == 0 ? 0 : num % 2 == 0 ? NumberOfSteps(num / 2) + 1 : NumberOfSteps(num - 1) + 1;
        }
        public static int StrCount(string str, char letter)
        {
            int countLetter = 0;
            foreach (char letStr in str)
            {
                if (letStr == letter)
                    countLetter++;
            }
            return countLetter;
        }

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
            while (queueCheck.Count > 0)
            {
                coord = queueCheck.Dequeue();
                mask[coord.x][coord.y] = true;


                for (int i = 0; i < 4; i++)
                {
                    int shiftX = coord.x;
                    int shiftY = coord.y;
                    switch (i)
                    {
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

                    if (!CheckOutOfRange(shiftX, shiftY, hieght, width) &&
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
            if (x < 0 || x >= hight || y < 0 || y >= width)
                return true;
            return false;
        }
    }
}
