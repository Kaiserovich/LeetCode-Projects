using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Algorithms
    {
        int BinarySearch(int[] mass, int x)
        {
            int leftBorder = 0;
            int rightBorder = mass.Length;

            while (leftBorder <= rightBorder)
            {
                int center = (leftBorder + rightBorder) / 2;

                if (mass[center] == x)
                    return center;

                if (mass[center] > x)
                    rightBorder = center - 1;
                else
                    leftBorder = center + 1;
            }
            return -1;
        }

        int RecursiveBinarySearch(int[] mass, int leftBorder, int rightBorder, int x)
        {
            if (leftBorder > rightBorder)
                return -1;

            int center = (leftBorder + rightBorder) / 2;

            if (mass[center] == x)
                return center;

            if (mass[center] > x)
                return RecursiveBinarySearch(mass, leftBorder, center - 1, x);
            else
                return RecursiveBinarySearch(mass, center + 1, rightBorder, x);
        }

        int[] SelectionSort(int[] mass) {
            for (int i = 0; i < mass.Length - 1; i++)
            {
                int smallest = i;

                for (int j = 0; j < mass.Length; j++)
                    if (mass[j] < mass[smallest])
                        smallest = j;

                int temp = mass[i];
                mass[i] = mass[smallest];
                mass[smallest] = temp;
            }
            return mass;
        }
    }
}
