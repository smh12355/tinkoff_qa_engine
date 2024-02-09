using System;
using System.Text;
using System.Linq;
using System.Runtime.InteropServices;

namespace tinkoff_test_new
{
    internal class second
    {
        internal static void test()
        {
            string N = Console.ReadLine();
            string[] carts = Console.ReadLine().Split(' ');
            int[] carts_int = Array.ConvertAll<string,int>(carts,int.Parse);
            Array.Sort<int>(carts_int);
            int counter_index = 1;
            int counter_value = carts_int[0];
            for (int i = 1; i <= carts_int.GetUpperBound(0); i++)
            {
                if (carts_int[i] != counter_value)   
                {
                    if (counter_index == 4)
                    {
                        counter_index = 1;
                        counter_value = carts_int[i];
                        continue;
                    }
                    else
                    {
                        counter_index = 4;
                        Console.WriteLine(counter_value);
                        break;
                    }
                }
                counter_index++;
            }
            if (counter_index != 4)
            {
                Console.WriteLine(counter_value);
            }

        }
    }
}
