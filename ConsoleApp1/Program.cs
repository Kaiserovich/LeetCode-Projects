using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace PracticeConsoleApp
{
    public static partial class Kata
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
        public static int SubarraySum(int[] nums, int k)
        {
            int subArrays = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int subArraySum = 0;
                for (int j = i; j < nums.Length; j++)
                    subArraySum += nums[j];
                    if (subArraySum == k)
                        subArrays++;
            }
            return subArrays;
        }
}

