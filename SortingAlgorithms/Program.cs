using System;

namespace SortingAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortingAlgorithms s = new SortingAlgorithms();
            int[] arr = { 20,30,5,6,7,8 };
            s.bubbleSort(arr);
            s.print(arr);

        }
    }
}