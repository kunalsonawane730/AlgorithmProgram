using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class InsertionSort
    {
        public void InsertionSorting()
        {
            string[] strgArray = { "One", "Seven", "Four", "Nine", "Six" };

            System.Console.WriteLine("Before sort array is:");
            foreach (var item in strgArray)
            {
                Console.WriteLine(item);
            }

            for (int i = 1; i < strgArray.Length; i++)
            {
                string value = strgArray[i];
                int j = i - 1;
                while ((j >= 0) && (strgArray[j].CompareTo(value) > 0))
                {
                    strgArray[j + 1] = strgArray[j];
                    j--;
                }
                strgArray[j + 1] = value;
            }

            System.Console.WriteLine("Afer sort array is:");
            foreach (var item in strgArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
