using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tinkoff_test_new
{
    internal class DataScience1
    {
        internal static void test()
        {
            List<int> abcd = new List<int>();
            for (int i = 0; i < 4; i++)
            {
                abcd.Add(int.Parse(Console.ReadLine()));
            }
            if (abcd[0] == 0 && abcd[1] == 0)
            {
                Console.WriteLine("INF");
            }
            else if (abcd[0] == 0)
            {
                Console.WriteLine("NO");
            }
            else if (abcd[0] / abcd[2] == abcd[1] / abcd[3] && abcd[0] % abcd[2] == abcd[1] % abcd[3])
            {
                Console.WriteLine("NO");
            }
            else if (abcd[1] % abcd[0] == 0)
            {
                Console.WriteLine(-1 * abcd[1] / abcd[0]);
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
