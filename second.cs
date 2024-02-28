using System;
using System.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Net.Mail;

namespace tinkoff_test_new
{
    internal class second
    {
        internal static void test()
        {
            string N = Console.ReadLine();
            int[] carts = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Array.Sort<int>(carts);
            for (int i = 0; i < carts.GetUpperBound(0) - 2; i+=4)
            {
                if (carts[i] != carts[i+3])
                {
                    Console.WriteLine(carts[i]);
                    return;
                }
            }
            Console.WriteLine(carts[carts.GetUpperBound(0) - 2]);
        }
    }
}
