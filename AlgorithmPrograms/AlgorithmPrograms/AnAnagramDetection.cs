using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class AnAnagramDetection
    {
        public void AnagramDetection()
        {
            System.Console.WriteLine("Enter two string to do Anagram:");
            string inputstrg1 = Console.ReadLine();
            string inputstrg2 = Console.ReadLine();

            char[] saveChar1 = inputstrg1.ToLower().ToCharArray();
            char[] saveChar2 = inputstrg2.ToLower().ToCharArray();

            Array.Sort(saveChar1);
            Array.Sort(saveChar2);

            string obj1 = new string(saveChar1);
            string obj2 = new string(saveChar2);

            if (obj1.Equals(obj2))
            {
                Console.WriteLine("Both strings are Anagram");
            }
            else
            {
                Console.WriteLine("Both strings are not Anagram");
            }
        }
    }
}
