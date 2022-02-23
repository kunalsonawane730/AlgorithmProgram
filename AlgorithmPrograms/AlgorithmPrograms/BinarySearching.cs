using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class BinarySearching
    {
        public void BinarySearch(string UserInput)
        {
            string[] strinputArray = { "jkl", "nice", "vehicles", "matter", "langauge" };
            int min = 0, mid = 0, result = -1;
            int max = strinputArray.Length - 1;

            Console.WriteLine("Array values are:");
            for (int i = 0; i <= max; i++)
            {
                Console.WriteLine(strinputArray[i]);
            }
                Console.WriteLine("\n");

            while (min <= max)
            {
                mid = min + (min - 1) / 2;

                if (UserInput.Equals(strinputArray[mid]))
                {
                    result = 0;
                }

                if (result == 0)
                {
                    Console.WriteLine("Matching found");
                }

                int val = Convert.ToInt32(UserInput.CompareTo(strinputArray[mid]));

                if (val == 1)
                {
                    min = mid + 1;
                    result = 1;
                }
                else
                {
                    max = mid - 1;
                    result = 1;
                }
            }

            if (result == -1)
            {
                Console.WriteLine("String is not found");
            }
            else if (result == 1)
            {
                Console.WriteLine("String is found");
            }
        }
    }
}
