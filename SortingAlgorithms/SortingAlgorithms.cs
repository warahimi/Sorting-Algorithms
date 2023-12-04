using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    internal class SortingAlgorithms
    {
        public void bubbleSort(int[] arr)
        {
            for(int i = 0; i < arr.Length - 1; i++)
            {
                bool swapped = false;
                for(int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                        swapped = true;
                    }
                }
                if(!swapped)
                {
                    break;
                }
            }
        }

        public void print(int[] arr) { 
            foreach(var item in arr)
            {
                Console.Write(item + " ");
            }
        }

    }
}
