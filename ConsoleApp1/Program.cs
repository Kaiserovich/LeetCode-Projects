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
            int[][] testMassiv = {
                new int[] { 2, 2, 2 },
                new int[] { 2, 0, 2 },
            };
            Kata.FloodFill(testMassiv, 0, 0, 1);
            Console.ReadKey();
        }
    }
}

