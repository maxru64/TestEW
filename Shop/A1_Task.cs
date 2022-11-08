using System;
using System.Collections.Generic;
using System.Linq;

namespace Shop
{
    public class A1_Task
    {
        public static int GetSumOfOddNumbers()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            return arr.Where(item => item % 2 == 0).Sum();
        }

        public static string GetUniqueString()
        {
            string str = "aaaafffffeeeeeefffff";
            return new string(str.Distinct().ToArray());
        }

        public static void PrintNumbers()
        {
            List<int> baseList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            baseList.RemoveAll(e => e % 2 == 0);
            Console.WriteLine(string.Join(", ", baseList));
        }
    }
}
