using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeConsoleApp
{
    public static partial class TinkoffExam
    {
        public static void TinkoffFirst()
        {
            string str = Console.ReadLine();
            var n = str.Split(' ').Select(Int32.Parse).ToArray();

            if ((n[0] >= n[1] && n[1] >= n[2] && n[2] >= n[3]) || (n[0] <= n[1] && n[1] <= n[2] && n[2] <= n[3]))
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
        public static string TinkoffFirstReturn(string str)
        {
            var n = str.Split(' ').Select(Int32.Parse).ToArray();

            return ((n[0] >= n[1] && n[1] >= n[2] && n[2] >= n[3]) || (n[0] <= n[1] && n[1] <= n[2] && n[2] <= n[3])) ? "YES" : "NO";
        }
        public static void TinkoffSecond()
        {
            string str = Console.ReadLine();
            var n = str.Split(' ').Select(Int32.Parse).ToArray();

            Console.WriteLine(n[0] * n[2] % n[1] != 0 ? n[0] * n[2] / n[1] + 1 : n[0] * n[2] / n[1]);
        }
        public static int TinkoffSecondReturn(string str)
        {
            var n = str.Split(' ').Select(Int32.Parse).ToArray();

            return n[0] * n[2] % n[1] != 0 ? n[0] * n[2] / n[1] + 1 : n[0] * n[2] / n[1];
        }
        public static void TinkoffThird()
        {
            string length = Console.ReadLine();
            string str = Console.ReadLine();

            int minSubstrLength = -1;

            for (int i = 0; i < str.Length; i++)
            {
                bool a = false, b = false, c = false, d = false;
                for (int j = i; j < str.Length; j++)
                {
                    if (str[j] == 'a')
                        a = true;
                    if (str[j] == 'b')
                        b = true;
                    if (str[j] == 'c')
                        c = true;
                    if (str[j] == 'd')
                        d = true;
                    if (a == true && b == true && c == true && d == true)
                        if (j - i + 1 < minSubstrLength || minSubstrLength == -1)
                        {
                            minSubstrLength = j - i + 1;
                            break;
                        }
                }
            }
            Console.WriteLine(minSubstrLength);
        }
        public static int TinkoffThirdReturn(string str)
        {
            int minSubstrLength = -1;

            for (int i = 0; i < str.Length; i++)
            {
                bool a = false, b = false, c = false, d = false;
                for (int j = i; j < str.Length; j++)
                {
                    if (str[j] == 'a')
                        a = true;
                    if (str[j] == 'b')
                        b = true;
                    if (str[j] == 'c')
                        c = true;
                    if (str[j] == 'd')
                        d = true;
                    if (a == true && b == true && c == true && d == true)
                        if (j - i + 1 < minSubstrLength || minSubstrLength == -1) 
                        {
                            minSubstrLength = j - i + 1;
                            break;
                        }
                }
            }
            return minSubstrLength;
        }
        public static void TinkoffFourth()
        {
            string length = Console.ReadLine();
            string str = Console.ReadLine();

            var n = str.Split(' ').Select(Int32.Parse).ToArray();
            var output = n
                .GroupBy(word => word)
                .OrderByDescending(group => group.Count())
                .Select(group => group.Count());

            int maxSubstrLength = 0;
            var countMaxElements = output.Where(x => x == output.Max()).Count();
            var countAlmostMaxElements = output.Where(x => x == output.Max() - 1).Count();
            var almostMaxElement = output.Where(x => x == output.Max() - 1).FirstOrDefault();
            maxSubstrLength = Math.Max(maxSubstrLength, output.Max() * countMaxElements + (countMaxElements != 1 ? almostMaxElement : almostMaxElement * countAlmostMaxElements));
            Console.WriteLine(maxSubstrLength);
        }
        public static int TinkoffFourthReturn(string str)
        {
            var n = str.Split(' ').Select(Int32.Parse).ToArray();
            var output = n
                .GroupBy(word => word)
                .OrderByDescending(group => group.Count())
                .Select(group => group.Count());

            int maxSubstrLength = 0;
            int almostMaxElement = 0;

            var countMaxElements = output.Where(x => x == output.Max()).Count();
            var countAlmostMaxElements = output.Where(x => x == output.Max() - 1).Count();
            almostMaxElement = output.Where(x => x == output.Max() - 1).FirstOrDefault();
                maxSubstrLength = Math.Max(maxSubstrLength, output.Max() * countMaxElements + (countMaxElements != 1 ? almostMaxElement : almostMaxElement * countAlmostMaxElements)) ;
            return maxSubstrLength;
        }
        public static void TinkoffFifth()
        {
            string length = Console.ReadLine();
            string str = Console.ReadLine();

            var n = str.Split(' ').Select(Int32.Parse).ToArray();
            int countNormalSegment = 0;
            for (int i = 0; i < n.Length - 1; i++)
                for (int j = n.Length; j > i; j--)
                {
                    bool reasonableSegment = false;
                    int sumSubMas = 0;

                    for (int k = i; k < j - 1; k++)
                    {
                        for (int m = k; m < j; m++)
                        {
                            sumSubMas += n[m];
                            if (sumSubMas == 0)
                                reasonableSegment = true;
                        }
                        if (reasonableSegment == true)
                            break;
                    }
                    if (reasonableSegment == true)
                        countNormalSegment++;
                }
            Console.WriteLine(countNormalSegment);
        }
        public static int TinkoffFifthReturn(string str)
        {
            var n = str.Split(' ').Select(Int32.Parse).ToArray();
            int countNormalSegment = 0;
            for (int i = 0; i < n.Length - 1; i++)
                for (int j = n.Length; j > i; j--)
                {
                    bool reasonableSegment = false;
                    int sumSubMas = 0;

                    for (int k = i; k < j - 1; k++)
                    {
                        for (int m = k; m < j; m++)
                        {
                            sumSubMas += n[m];
                            if (sumSubMas == 0)
                                reasonableSegment = true;
                        }
                        if (reasonableSegment == true)
                            break;
                    }
                    if (reasonableSegment == true)
                        countNormalSegment++;
                }
            return countNormalSegment;
        }
        public static void TinkoffSixth()
        {
            var numberStudentsAndLimitScore = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();
            int countStudents = numberStudentsAndLimitScore[0];
            int limitScore = numberStudentsAndLimitScore[1];
            int median = countStudents / 2;
            List<int[]> values = new List<int[]>();
            string[] results = new string[countStudents];
            for (int i = 0; i < countStudents; i++)
            {
                string item = Console.ReadLine();
                values.Add(item.Split(' ').Select(Int32.Parse).ToArray());
            }
            values = values.OrderBy(x => x[1]).ThenBy(group => group[0]).ToList();

            for (int i = 0; i < countStudents; i++)
            {
                if (i < median)
                    values[i][1] = values[i][0];
                if (i > median)
                {
                    if (values[median][1] > values[i][0])
                        values[i][1] = values[median][1];
                    else
                        values[i][1] = values[i][0];
                }
            }
            while (values.Sum(x => x[1]) > limitScore)
            {
                values[median][1]--;

                for (int i = median + 1; i < countStudents; i++)
                {
                    if (values[median][1] > values[i][0])
                        values[i][1] = values[median][1];
                    else
                        values[i][1] = values[i][0];
                }
            }
            Console.WriteLine(values[median][1]);
        }
        public static int TinkoffSixthReturn(string numberStudentsAndLimitScore, string[] results)
        {

            var n = numberStudentsAndLimitScore.Split(' ').Select(Int32.Parse).ToArray();
            int countStudents = n[0];
            int limitScore = n[1];
            int median = countStudents / 2;
            List<int[]> values = new List<int[]>();

            foreach (string item in results)
                values.Add(item.Split(' ').Select(Int32.Parse).ToArray());

            values = values.OrderBy(x => x[1]).ThenBy(group => group[0]).ToList();

            for (int i = 0; i < countStudents; i++)
            {
                if (i < median)
                    values[i][1] = values[i][0];
                if (i > median)
                {
                    if (values[median][1] > values[i][0])
                        values[i][1] = values[median][1];
                    else
                        values[i][1] = values[i][0];
                }
            }
            while (values.Sum(x=> x[1]) > limitScore)
            {
                values[median][1]--;

                for (int i = median+1; i < countStudents; i++)
                {
                        if (values[median][1] > values[i][0])
                            values[i][1] = values[median][1];
                        else
                            values[i][1] = values[i][0];
                }
            }
            return values[median][1];
        }
    }
}



/*
 	using System;
    using System.Linq;
    using System.Collections.Generic;

	namespace ConsoleApp2
	{
	    class Program
	    {
	        static void Main(string[] args)
	        {
	            int a = int.Parse(Console.ReadLine());
	            int b = int.Parse(Console.ReadLine());
	            Console.WriteLine(a + b);
	        }
	    }
	}
 */
