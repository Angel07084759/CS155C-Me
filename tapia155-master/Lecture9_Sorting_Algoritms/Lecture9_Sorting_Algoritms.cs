using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture9_Sorting_Algoritms
{
    class Lecture9_Sorting_Algoritms
    {
        public static void exchange(int[] data, int m, int n)
        {
            int temporary;

            temporary = data[m];
            data[m] = data[n];
            data[n] = temporary;
        }

        public static void IntArrayBubbleSort(int[] data)
        {
            int i, j;
            int N = data.Length;

            for (j = N - 1; j > 0; j--)
            {
                for (i = 0; i < j; i++)
                {
                    if (data[i] > data[i + 1])
                        exchange(data, i, i + 1);
                }
            }
        }

        public static int IntArrayMin(int[] data, int start)
        {
            int minPos = start;
            for (int pos = start + 1; pos < data.Length; pos++)
                if (data[pos] < data[minPos])
                    minPos = pos;
            return minPos;
        }

        public static void IntArraySelectionSort(int[] data)
        {
            int i;
            int N = data.Length;

            for (i = 0; i < N - 1; i++)
            {
                int k = IntArrayMin(data, i);
                if (i != k)
                    exchange(data, i, k);
            }
        }

        public static void PrintArray(int [] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] data = new int[] {7, 2, 8, 12, 3 };

            PrintArray(data);
            IntArraySelectionSort(data);
            PrintArray(data);


            Console.ReadLine();

        }
    }
}
