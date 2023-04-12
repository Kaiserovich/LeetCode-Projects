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
            MyClass myClass = new MyClass();
            myClass.Search("0");
            Console.ReadKey();
        }
    }
}

