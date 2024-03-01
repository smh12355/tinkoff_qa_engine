using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tinkoff_test_new
{
    internal class DataScience
    {
        internal static void test()
        {
            string[] text = Console.ReadLine().Split().Select(x => x).ToArray();
            int[] size = text.Select(x => x.Length).ToArray();
            Console.WriteLine(text[Array.IndexOf(size, size.Max())]);
            Console.WriteLine(size.Max());
            ////string[] text = Console.ReadLine().Split();
            //text[0].Length
        }
    }
}
