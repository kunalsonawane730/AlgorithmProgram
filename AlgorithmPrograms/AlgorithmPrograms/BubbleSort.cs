using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class BubbleSort
    {
        public void BubbleSorting()
        {
            int[] inputArray = { 56, 77, 65, 98, 31 };
            int temp;

            Console.WriteLine("Array before sorting is: ");
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.Write(inputArray[i] + " ");
            }

            for (int j = 0; j <= inputArray.Length - 2; j++)
            {
                for (int i = 0; i <= inputArray.Length - 2; i++)
                {
                    if (inputArray[i] > inputArray[i + 1])
                    {
                        temp = inputArray[i + 1];
                        inputArray[i + 1] = inputArray[i];
                        inputArray[i] = temp;
                    }
                }
            }
            Console.WriteLine("\nSorted array is:");

            foreach (int data in inputArray)
            {
                Console.Write(data + " ");
            }

        }
    }
}
