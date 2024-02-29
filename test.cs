using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tinkoff_test_new
{
    internal class test
    {
        internal static void test1()
        {
            int[] ABCD = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if (ABCD[3] > ABCD[1])
            {
                Console.WriteLine((ABCD[3] - ABCD[1]) * ABCD[2] + ABCD[0]);
            }
            else
            {
                Console.WriteLine(ABCD[0]);
            }
        }
    }
}
