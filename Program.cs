using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_7_23_Assign_14
{
    internal class Program
    {
        public static void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }
        public static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n");
        }

        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            bool swapped;
            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped)
                {
                    break;
                }
            }
        }

        static void Main(string[] args)
        {
            int[] arr= {2,4,6,8,7,5,3,1,9 };          
            Console.WriteLine("Print array without sort");
            Print(arr);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            InsertionSort(arr);
            stopwatch.Stop();
            Console.WriteLine("After Insertion sort");
            Print(arr);
            Console.WriteLine($"ArraySize {arr.Length} Time Taken {stopwatch.Elapsed.TotalMilliseconds} milliseconds");

            int[] arr1 = { 2, 4, 6, 8, 7, 5, 3, 1, 9 };
            Console.WriteLine("Print array without sort");
            Print(arr1);
            Stopwatch stopwatch1 = new Stopwatch();
            stopwatch1.Start();
            BubbleSort(arr1);
            stopwatch1.Stop();
            Console.WriteLine("After Bubble sort");
            Print(arr1);
            Console.WriteLine($"ArraySize {arr1.Length} Time Taken {stopwatch1.Elapsed.TotalMilliseconds} milliseconds");
            Console.ReadKey();
          
        }
    }
}
