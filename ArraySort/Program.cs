using System;
using System.Diagnostics;

namespace ArraySort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array");
            string s = Console.ReadLine();
            var charArray = s.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            int[] intArray = new int[charArray.Length];
            
            for (int i = 0; i < charArray.Length; i++)
            {
                if (!int.TryParse(charArray[i], out intArray[i]))
                {
                    intArray[i] = 0;
                }
            }

            var sw = new Stopwatch();
            var quickSortArray = new int[intArray.Length];
            Array.Copy(intArray, quickSortArray, intArray.Length);
            sw.Start();

            ArraySorter.QuickSorting(quickSortArray, 0, quickSortArray.Length - 1);
            sw.Stop();
            Console.WriteLine("QuickSort");
            foreach (var item in quickSortArray)
            {
                Console.Write("\t{0}", item);
            }
            Console.WriteLine("\nВремя сортировки: {0}", sw.Elapsed);
            Console.WriteLine();


            var insertionSortArray = new int[intArray.Length];
            Array.Copy(intArray, insertionSortArray, intArray.Length);
            sw.Reset();
            sw.Start();
            ArraySorter.InsertionSorting(insertionSortArray);
            sw.Stop();
            Console.WriteLine("InsertionSort");
            foreach (var item in insertionSortArray)
            {
                Console.Write("\t{0}", item);
            }
            Console.WriteLine("\nВремя сортировки: {0}", sw.Elapsed);
            Console.WriteLine();

            var mergeSortArray = new int[intArray.Length];
            Array.Copy(intArray, mergeSortArray, intArray.Length);
            sw.Reset();
            sw.Start();
            ArraySorter.MergeSorting(mergeSortArray, 0, mergeSortArray.Length-1);
            sw.Stop();
            Console.WriteLine("MergeSort");
            foreach (var item in mergeSortArray)
            {
                Console.Write("\t{0}", item);
            }
            Console.WriteLine();
            Console.WriteLine("Время сортировки: {0}", sw.Elapsed);
            Console.ReadKey();
        }   
    }
}
